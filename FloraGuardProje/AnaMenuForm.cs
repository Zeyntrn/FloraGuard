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
    public partial class AnaMenuForm : Form
    {
        private Kullanici aktifKullanici;

        public AnaMenuForm(Kullanici kullanici)
        {
            InitializeComponent();
            aktifKullanici = kullanici;
        }



        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            // Yetki kontrolü
            if (KullaniciSession.AktifKullanici != null)
            {
                string yetki = KullaniciSession.AktifKullanici.KullaniciTipi;

                if (yetki == "Personel")
                {
                    // Personel kullanıcıları için bazı butonları pasifleştir veya gizle
                    btnKullaniciYonetim.Enabled = false;
                    btnLoglar.Enabled = false;
                }


            }
        }
    }
}
