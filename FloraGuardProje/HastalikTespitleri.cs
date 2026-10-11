using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System.IO;
using static System.Collections.Specialized.BitVector32;
using System.Drawing.Imaging;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using AForge.Video;
using AForge.Video.DirectShow;


namespace FloraGuardProje
{
    public partial class HastalikTespitleri : Form
    {
        InferenceSession session;
        string[] classNames;
        VideoCapture capture;
        Mat frame;
        Bitmap bitmap;
        System.Windows.Forms.Timer timer;
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        Bitmap currentFrame;

        public HastalikTespitleri()
        {
            InitializeComponent();

            // Modeli yükle
            session = new InferenceSession("bitki_hastalik_modeli.onnx");

            // Sınıf isimleri (alfabetik sıralı olmalı)
            classNames = new string[]
            {
            "Tomato_Bacterial_spot",
            "Tomato_Early_blight",
            "Tomato_Late_blight",
            "Tomato_Leaf_Mold",
            "Tomato_Septoria_leaf_spot",
            "Tomato_Spider_mites_Two_spotted_spider_mite",
            "Tomato_Target_Spot",
            "Tomato_Tomato_YellowLeaf__Curl_Virus",
            "Tomato_Tomato_mosaic_virus",
            "Tomato_healthy"
            };
        }



        private async void btnAnalizEt_Click(object sender, EventArgs e)
        {

            string prompt = $"Aşağıdaki belirtilere göre, sadece bu yeni giriş üzerinden analiz yap:\n" +
                $"\"{txtAnalizGirdi.Text}\"\n\n" +
                "Bu belirtilere göre:\n" +
                "- Belirtiler:\n- Nedenler:\n- Çözümler:\n" +
                "Lütfen geçmiş cevaplara göre değil, sadece bu yeni girdiye göre yanıt ver.";

            ChatGPTClient client = new ChatGPTClient();
            string cevap = await client.GetChatGPTResponse(prompt);

            // Cevabı 3 parçaya ayırıyoruz
            string[] bolumler = cevap.Split(new[] { "Belirtiler:", "Nedenler:", "Çözümler:" }, StringSplitOptions.None);

            if (bolumler.Length >= 4)
            {
                txtBelirtiler.Text = bolumler[1].Trim();
                txtNedenler.Text = bolumler[2].Trim();      // ← BU SATIR EKSİKTİ
                txtCozumler.Text = bolumler[3].Trim();
            }
            else
            {
                MessageBox.Show("Yanıt düzgün ayrıştırılamadı:\n\n" + cevap);
            }

        }


        private void HastalikTespitleri_Load(object sender, EventArgs e)
        {

        }

        private void buttonhastaliktani_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }

            // PictureBox'tan alınan resmi 224x224'e çevir
            Bitmap resized = new Bitmap(pictureBox1.Image, new System.Drawing.Size(224, 224));

            float[] imageData = BitmapToFloatArray(resized);

            // DenseTensor oluştururken veriyi doğrudan veriyoruz
            var inputTensor = new DenseTensor<float>(imageData, new[] { 1, 224, 224, 3 });

            var inputs = new List<NamedOnnxValue>
{
    NamedOnnxValue.CreateFromTensor("input_layer", inputTensor) // Gerekirse input adını güncelleriz
};

            using var results = session.Run(inputs);
            var output = results.First().AsEnumerable<float>().ToArray();

            int maxIndex = Array.IndexOf(output, output.Max());
            string prediction = classNames[maxIndex];
            float confidence = output.Max() * 100;

            MessageBox.Show($"Tahmin: {prediction}\nGüven: %{confidence:F2}");

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resimler|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }


        private float[] BitmapToFloatArray(Bitmap bmp)
        {
            float[] result = new float[224 * 224 * 3];
            int i = 0;

            for (int y = 0; y < 224; y++)
            {
                for (int x = 0; x < 224; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    result[i++] = pixel.B / 255f;
                    result[i++] = pixel.G / 255f;
                    result[i++] = pixel.R / 255f;
                }
            }

            return result;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            currentFrame = (Bitmap)eventArgs.Frame.Clone(); // Son görüntüyü sakla
            pictureBox1.Image = (Bitmap)currentFrame.Clone(); // Ekrana aktar
        }

        private void buttonkamerabaslat_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Kamera bulunamadı!");
                return;
            }

            // İstediğin kamerayı seç (0: genelde USB kamera olur)
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void HastalikTespitleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentFrame == null)
            {
                MessageBox.Show("Canlı görüntü alınamadı.");
                return;
            }


            Bitmap resized = new Bitmap(currentFrame, new System.Drawing.Size(224, 224));
            float[] imageData = BitmapToFloatArray(resized);

            var inputTensor = new DenseTensor<float>(imageData, new[] { 1, 224, 224, 3 });

            var inputs = new List<NamedOnnxValue>
    {
        NamedOnnxValue.CreateFromTensor("input_layer", inputTensor)
    };

            using var results = session.Run(inputs);
            var output = results.First().AsEnumerable<float>().ToArray();

            int maxIndex = Array.IndexOf(output, output.Max());
            string prediction = classNames[maxIndex];
            float confidence = output.Max() * 100;

            txtAnalizGirdi.Text = prediction.Replace('_', ' ');
            MessageBox.Show($"Tahmin: {prediction}\nGüven: %{confidence:F2}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
