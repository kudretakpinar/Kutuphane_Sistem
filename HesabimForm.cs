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
    public partial class HesabimForm : Form
    {
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;
        private readonly Kullanici kullanici;


        public HesabimForm(Kullanici kullanici, KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            this.kullanici = kullanici;
            KullaniciVeriOku();
            ListeGuncelle();
        }

        private void ListeGuncelle()
        {
            dgvOduncKitap.DataSource = null;
            dgvOduncKitap.DataSource = kullanici.OduncAlinanKitaplar;
        }

        private void KullaniciVeriOku()
        {
            lblId.Text = $"ID: {kullanici.Id}";
            lblAdSoyad.Text = $"Ad Soyad: {kullanici.AdSoyad}";
            lblKullaniciAdi.Text = $"Kullanıcı Adı: {kullanici.KullaniciAd}";
            lblParola.Text = $"Parola: {kullanici.Parola}";
        }

        

        private void dgvOduncKitap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOduncKitap.SelectedRows.Count ==0)
            {
                dtpSonTeslimTarih.Value = DateTime.Now;
                return;
            }

            Kitap kitap = (Kitap)dgvOduncKitap.SelectedRows[0].DataBoundItem;
            dtpSonTeslimTarih.Value = (DateTime)kitap.AlinmaTarihi.Value;
            dtpSonTeslimTarih.Value = dtpSonTeslimTarih.Value.AddDays(14);

        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvOduncKitap.SelectedRows.Count==0)
            {
                MessageBox.Show("Teslim edilecek kitabı seçiniz");
                return;
            }

            Kitap kitap = (Kitap)dgvOduncKitap.SelectedRows[0].DataBoundItem;

            kutuphaneYoneticisi.Kitaplar.Add(kitap);
            kullanici.OduncAlinanKitaplar.Remove(kitap);

            ListeGuncelle();

           

        }
    }
}
