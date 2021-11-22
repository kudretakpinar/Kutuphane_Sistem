using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneKayit
{
    public partial class Form1 : Form
    {
        KullaniciYoneticisi kullaniciYoneticisi;

        Kullanici kullanici = new Kullanici();

        public Form1()
        {
            VerileriOku();
            InitializeComponent();
        }


        private void lnklKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm kayitOl = new KayitOlForm(kullaniciYoneticisi);
            kayitOl.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();

        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kullaniciYoneticisi);
            File.WriteAllText("veri.json", json);

        }
        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                kullaniciYoneticisi = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);

            }
            catch (Exception)
            {
                kullaniciYoneticisi = new KullaniciYoneticisi();
                
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici girisYapan = kullaniciYoneticisi.OturumAcma(txtKullanıcıAd.Text.Trim(), txtParola.Text);

            if (girisYapan != null)
            {
                MessageBox.Show("Giriş Başarılı");

            }
            else
                MessageBox.Show("Hatalı Giriş");

            KutuphaneForm kutuphaneForm = new KutuphaneForm(girisYapan);
            kutuphaneForm.ShowDialog();


        }
    }
}
