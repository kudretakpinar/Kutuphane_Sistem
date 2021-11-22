using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneKayit
{
    public partial class KayitOlForm : Form
    {
        private readonly KullaniciYoneticisi kullaniciYonetici;

        

        public KayitOlForm(KullaniciYoneticisi kullaniciYoneticisi)
        {
            InitializeComponent();
            this.kullaniciYonetici = kullaniciYoneticisi;

            txtKayıtParolaTekrar.TextChanged += TxtKayıtParolaTekrar_TextChanged;
        }

        private void TxtKayıtParolaTekrar_TextChanged(object sender, EventArgs e)
        {
            lblParolaEs.Visible = true;


            if (txtKayıtParola.Text != txtKayıtParolaTekrar.Text)
            {
                lblParolaEs.ForeColor = Color.Red;
                lblParolaEs.Text = "Parola Eşleşmiyor";
            }
            else if (txtKayıtParola.Text == txtKayıtParolaTekrar.Text && txtKayıtParola != null && txtKayıtParolaTekrar != null)
            {

                lblParolaEs.ForeColor = Color.Blue;
                lblParolaEs.Text = "Parola Eşleşiyor";
            }

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string adSoyad = txtKayıtAd.Text.Trim();
            string kullaniciAd = txtKayıtKullanıcıAd.Text.Trim();
            string parola = txtKayıtParola.Text.Trim();
            string parolaTekrar = txtKayıtParolaTekrar.Text.Trim();


            if (adSoyad == "" || kullaniciAd == "")
            {
                MessageBox.Show("Bilgileri kontrol edin");
                return; 
            }
            kullaniciYonetici.KayitOlma(adSoyad, kullaniciAd, parola);

            MessageBox.Show("Kayıt İşlemi Başarılı");
            Close();
        }

        private void txtKayıtKullanıcıAd_TextChanged(object sender, EventArgs e)
        {
            lblParolaEs.Visible = true;


            if (kullaniciYonetici.KullaniciVarmi(txtKayıtKullanıcıAd.Text.Trim()) || string.IsNullOrEmpty(txtKayıtKullanıcıAd.Text))
            {
                lblParolaEs.Text = "Kullanıcı adı uygun değil";
                lblParolaEs.ForeColor = Color.Red;
            }
            else
            {
                lblParolaEs.Text = "Kullanıcı Adı Uygun";
                lblParolaEs.ForeColor = Color.Green;
            }
        }
    }
}
