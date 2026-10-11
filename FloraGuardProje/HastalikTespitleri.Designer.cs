namespace FloraGuardProje
{
    partial class HastalikTespitleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastalikTespitleri));
            resim = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAnalizEt = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBelirtiler = new TextBox();
            txtNedenler = new TextBox();
            txtCozumler = new TextBox();
            txtAnalizGirdi = new TextBox();
            buttonhastaliktani = new Button();
            openFileDialog1 = new OpenFileDialog();
            buttonkamerabaslat = new Button();
            ((System.ComponentModel.ISupportInitialize)resim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resim
            // 
            resim.Image = (Image)resources.GetObject("resim.Image");
            resim.Location = new Point(1, 1);
            resim.Name = "resim";
            resim.Size = new Size(258, 215);
            resim.SizeMode = PictureBoxSizeMode.StretchImage;
            resim.TabIndex = 3;
            resim.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 440);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(199, 691);
            label1.Name = "label1";
            label1.Size = new Size(391, 28);
            label1.TabIndex = 5;
            label1.Text = "Hastalık Tespitini yapıp buraya yazacak ";
            label1.Click += label1_Click;
            // 
            // btnAnalizEt
            // 
            btnAnalizEt.BackColor = Color.Transparent;
            btnAnalizEt.FlatStyle = FlatStyle.Popup;
            btnAnalizEt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAnalizEt.Location = new Point(108, 871);
            btnAnalizEt.Name = "btnAnalizEt";
            btnAnalizEt.Size = new Size(194, 55);
            btnAnalizEt.TabIndex = 6;
            btnAnalizEt.Text = "Analiz et ";
            btnAnalizEt.UseVisualStyleBackColor = false;
            btnAnalizEt.Click += btnAnalizEt_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button2.Location = new Point(486, 871);
            button2.Name = "button2";
            button2.Size = new Size(194, 55);
            button2.TabIndex = 7;
            button2.Text = "İlaçlama Yap";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(1347, 98);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 8;
            label2.Text = "HASTALIK DETAYLARI ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(1020, 188);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 9;
            label3.Text = "BELİRTİLERİ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(1020, 472);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 10;
            label4.Text = "NEDENLERİ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(1017, 762);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 11;
            label5.Text = "ÇÖZÜMLERİ :";
            // 
            // txtBelirtiler
            // 
            txtBelirtiler.Location = new Point(1232, 185);
            txtBelirtiler.Multiline = true;
            txtBelirtiler.Name = "txtBelirtiler";
            txtBelirtiler.Size = new Size(534, 235);
            txtBelirtiler.TabIndex = 12;
            // 
            // txtNedenler
            // 
            txtNedenler.Location = new Point(1232, 472);
            txtNedenler.Multiline = true;
            txtNedenler.Name = "txtNedenler";
            txtNedenler.Size = new Size(541, 236);
            txtNedenler.TabIndex = 13;
            // 
            // txtCozumler
            // 
            txtCozumler.Location = new Point(1232, 762);
            txtCozumler.Multiline = true;
            txtCozumler.Name = "txtCozumler";
            txtCozumler.Size = new Size(541, 228);
            txtCozumler.TabIndex = 14;
            // 
            // txtAnalizGirdi
            // 
            txtAnalizGirdi.Location = new Point(217, 749);
            txtAnalizGirdi.Multiline = true;
            txtAnalizGirdi.Name = "txtAnalizGirdi";
            txtAnalizGirdi.Size = new Size(364, 106);
            txtAnalizGirdi.TabIndex = 15;
            // 
            // buttonhastaliktani
            // 
            buttonhastaliktani.BackColor = Color.Transparent;
            buttonhastaliktani.FlatStyle = FlatStyle.Popup;
            buttonhastaliktani.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            buttonhastaliktani.Location = new Point(108, 932);
            buttonhastaliktani.Name = "buttonhastaliktani";
            buttonhastaliktani.Size = new Size(194, 55);
            buttonhastaliktani.TabIndex = 16;
            buttonhastaliktani.Text = "Hastalık Tanıma";
            buttonhastaliktani.UseVisualStyleBackColor = false;
            buttonhastaliktani.Click += buttonhastaliktani_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonkamerabaslat
            // 
            buttonkamerabaslat.BackColor = Color.Transparent;
            buttonkamerabaslat.FlatStyle = FlatStyle.Popup;
            buttonkamerabaslat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            buttonkamerabaslat.Location = new Point(486, 932);
            buttonkamerabaslat.Name = "buttonkamerabaslat";
            buttonkamerabaslat.Size = new Size(194, 55);
            buttonkamerabaslat.TabIndex = 17;
            buttonkamerabaslat.Text = "Kamerayı Başlat";
            buttonkamerabaslat.UseVisualStyleBackColor = false;
            buttonkamerabaslat.Click += buttonkamerabaslat_Click;
            // 
            // HastalikTespitleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fLORAGUARD__1_;
            ClientSize = new Size(1924, 1014);
            Controls.Add(buttonkamerabaslat);
            Controls.Add(buttonhastaliktani);
            Controls.Add(txtAnalizGirdi);
            Controls.Add(txtCozumler);
            Controls.Add(txtNedenler);
            Controls.Add(txtBelirtiler);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnAnalizEt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(resim);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HastalikTespitleri";
            Text = "HastalikTespitleri";
            WindowState = FormWindowState.Maximized;
            FormClosing += HastalikTespitleri_FormClosing;
            Load += HastalikTespitleri_Load;
            ((System.ComponentModel.ISupportInitialize)resim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox resim;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAnalizEt;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBelirtiler;
        private TextBox txtNedenler;
        private TextBox txtCozumler;
        private TextBox txtAnalizGirdi;
        private Button buttonhastaliktani;
        private OpenFileDialog openFileDialog1;
        private Button buttonkamerabaslat;
    }
}