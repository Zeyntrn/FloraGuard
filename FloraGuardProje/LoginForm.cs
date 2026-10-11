using StokTakipSistemi;
using System.Data.SqlClient;

namespace FloraGuardProje
{
    public partial class LoginForm : Form
    {
        private KullaniciIslemleri kullaniciRepo;
        public LoginForm()
        {
            InitializeComponent();
            kullaniciRepo = new KullaniciIslemleri();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtKullaniciSifre.Text;

            try
            {
                KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
                var kullanici = kullaniciIslemleri.GirisYap(kullaniciAdi, sifre);

                if (kullanici != null)
                {
                    // Kullanýcýyý global olarak Session'a kaydet
                    KullaniciSession.AktifKullanici = kullanici;

                    MessageBox.Show("Hoþ geldiniz, " + kullanici.KullaniciAdi, "Giriþ Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AnaMenuForm anamenu = new AnaMenuForm(kullanici);
                    anamenu.ShowDialog();
               

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("? Kullanýcý adý veya þifre hatalý!", "Giriþ Baþarýsýz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriþ sýrasýnda bir hata oluþtu:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm kyt = new KayitOlForm();
            kyt.Show();
            this.Hide();
        }

        private void lnkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SýfreGuncellemeFrm sýfre = new SýfreGuncellemeFrm();
            sýfre.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtKullaniciSifre.PasswordChar = '*';
        }

        private void btnCýkýs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}