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
    public partial class KutuphaneForm : Form
    {
        KutuphaneYoneticisi kutuphaneYoneticisi;
        private readonly Kullanici kullanici;

        public KutuphaneForm(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            VerileriOku();
            TurleriEkle();
            DataGuncelle(kutuphaneYoneticisi.Kitaplar); // bağıs yaptıktan sonra kıtap odunc alınınca bu metod kullanılacak
        }

        private void DataGuncelle(List<Kitap> kitaplar)
        {
            dgvKitaplar.DataSource = null; // önce datasourcu boşalttık
            dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar;
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[7].Visible = false;
        }

        private void TurleriEkle()
        {
            cmbTurler.Items.Add("Hepsi");
            foreach (var item in Enum.GetValues(typeof(KitapTur)))
            {
                cmbTurler.Items.Add(item);
            }
            cmbTurler.SelectedIndex = 0; // default ilk eleman secılı gelsın(Hepsi)
            //foreach kısa yol- yada böyle tek tek ekleyebiliriz 
            //cmbTurler.Items.Add(KitapTur.Bilimkurgu);
            //cmbTurler.Items.Add(KitapTur.Biyografi);
            //cmbTurler.Items.Add(KitapTur.Egitim);
            //cmbTurler.Items.Add(KitapTur.Fantastik);
            //cmbTurler.Items.Add(KitapTur.Korku);
            //cmbTurler.Items.Add(KitapTur.Polisiye);
            //cmbTurler.Items.Add(KitapTur.Psikoloji);
            //cmbTurler.Items.Add(KitapTur.Tarih);



        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veriKutuphane.json");
                kutuphaneYoneticisi = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json);

            }
            catch (Exception)
            {
                kutuphaneYoneticisi = new KutuphaneYoneticisi();

            }
        }

        private void tsmiCikisYap_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            // sağ click olduysa
            if (e.Button == MouseButtons.Right)
            {
                var position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;
                }

            }
        }

        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {
            // Kütüphanedn secılı kıtabı kaldırıcam ve o ankı login olmus kullanıcının ödünç almış olduğu kitaplara eklicem
            // ve o anki tarih bilgisi kitap ödünç alınma tarıhıne eklenıcek

            //1. adım  seçili kıtabı bul
            Kitap arananKitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            arananKitap.AlinmaTarihi = DateTime.Now;
            //2. adım buldugum kıtabı kullanıcının ödunc aldıklarıma eklıcem

            kullanici.OduncAlinanKitaplar.Add(arananKitap);
            kutuphaneYoneticisi.Kitaplar.Remove(arananKitap);

            //3. adım o kıtabı kutuphanedekı kıtaplardan sıl
            DataGuncelle(kutuphaneYoneticisi.Kitaplar);
        }

        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kutuphaneYoneticisi);
            File.WriteAllText("veriKutuphane.json", json);
        }

        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hesabimForm = new HesabimForm(kullanici, kutuphaneYoneticisi);
            
            hesabimForm.ShowDialog();

            DataGuncelle(kutuphaneYoneticisi.Kitaplar);

        }

        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bagisForm = new BagisForm(kutuphaneYoneticisi);
            bagisForm.ShowDialog();
            DataGuncelle(kutuphaneYoneticisi.Kitaplar);
        }

        private void kitabıİmhaEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count ==0)
            {
                return;
            }

            Kitap kitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;

            kutuphaneYoneticisi.Kitaplar.Remove(kitap);
            DataGuncelle(kutuphaneYoneticisi.Kitaplar);
        }

        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitapArama();
        }

        private void KitapArama()
        {
            List<Kitap> seciliKitaplar = new List<Kitap>();

            string aranan = txtArama.Text.ToLower().Trim();

            seciliKitaplar.Clear();

            if (txtArama.Text != "" && cmbTurler.SelectedIndex !=0)
            {
                seciliKitaplar = kutuphaneYoneticisi.Kitaplar.Select(x => x).Where(x => x.Ad.ToLower().StartsWith(aranan) && x.KitapTur == (KitapTur)cmbTurler.SelectedItem).ToList();

                DataGuncelle(seciliKitaplar);
            }
            else if (cmbTurler.SelectedIndex !=0)
            {
                seciliKitaplar = kutuphaneYoneticisi.Kitaplar.Select(x => x).Where(x => x.KitapTur == (KitapTur)cmbTurler.SelectedItem).ToList();
                DataGuncelle(seciliKitaplar);

            }
            else if (txtArama.Text != "")
            {
                seciliKitaplar = kutuphaneYoneticisi.Kitaplar.Select(x => x).Where(x => x.Ad.ToLower().StartsWith(aranan)).ToList();

                DataGuncelle(seciliKitaplar);
            }
            else
            {
                DataGuncelle(kutuphaneYoneticisi.Kitaplar);
            }



        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            KitapArama();
        }
    }
}
