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
    public partial class KayitOlForm : Form
    {
        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            var kullanici = new Kullanici
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Email = txtMail.Text,
                BildirimAktif = chbBıldırımKontrl.Checked,
                KullaniciTipi = cmbKullaniciTuru.SelectedItem.ToString(),
                EklenmeTarihi = DateTime.Now
            };

            KullaniciIslemleri ıslem = new KullaniciIslemleri();
            bool kayitBasarili = ıslem.KayitOl(kullanici);

            MessageBox.Show(kayitBasarili ? "Kayıt başarılı!" : "Kayıt başarısız!");
            if (kayitBasarili) this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm giris = new LoginForm();
            giris.Show();
        }

        private void KayitOlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
