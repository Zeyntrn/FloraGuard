using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraGuardProje
{
    public partial class SıfreGuncellemeFrm : Form
    {
        public SıfreGuncellemeFrm()
        {
            InitializeComponent();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                string mail = txtMail.Text;
                string yeniSifre = txtSifre.Text;

                if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(yeniSifre))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                KullaniciIslemleri servis = new KullaniciIslemleri();
                if (servis.KullaniciVarMi(mail))
                {
                    servis.SifreGuncelle(mail, yeniSifre);
                    MessageBox.Show("Şifre güncellendi.");
                    this.Close();
                    LoginForm giris = new LoginForm();
                    giris.Show();
                }
                else
                {
                    MessageBox.Show("Bu e-posta sistemde bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void SıfreGuncellemeFrm_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm giris = new LoginForm();
            giris.Show();
        }
    }
}
