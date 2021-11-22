
namespace KutuphaneKayit
{
    partial class HesabimForm
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
            this.gbKullaniciBilgi = new System.Windows.Forms.GroupBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOduncKitap = new System.Windows.Forms.DataGridView();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSonTeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.gbKullaniciBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKullaniciBilgi
            // 
            this.gbKullaniciBilgi.Controls.Add(this.lblParola);
            this.gbKullaniciBilgi.Controls.Add(this.lblKullaniciAdi);
            this.gbKullaniciBilgi.Controls.Add(this.lblAdSoyad);
            this.gbKullaniciBilgi.Controls.Add(this.lblId);
            this.gbKullaniciBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbKullaniciBilgi.Location = new System.Drawing.Point(12, 12);
            this.gbKullaniciBilgi.Name = "gbKullaniciBilgi";
            this.gbKullaniciBilgi.Size = new System.Drawing.Size(350, 374);
            this.gbKullaniciBilgi.TabIndex = 0;
            this.gbKullaniciBilgi.TabStop = false;
            this.gbKullaniciBilgi.Text = "Kullanıcın Bilgileri";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(16, 235);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(81, 25);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(16, 177);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(139, 25);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(16, 116);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(114, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 62);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOduncKitap);
            this.groupBox1.Controls.Add(this.btnTeslimEt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpSonTeslimTarih);
            this.groupBox1.Location = new System.Drawing.Point(384, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünc Alınan Kitaplar";
            // 
            // dgvOduncKitap
            // 
            this.dgvOduncKitap.AllowUserToAddRows = false;
            this.dgvOduncKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOduncKitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOduncKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncKitap.Location = new System.Drawing.Point(6, 34);
            this.dgvOduncKitap.MultiSelect = false;
            this.dgvOduncKitap.Name = "dgvOduncKitap";
            this.dgvOduncKitap.ReadOnly = true;
            this.dgvOduncKitap.RowHeadersWidth = 62;
            this.dgvOduncKitap.RowTemplate.Height = 28;
            this.dgvOduncKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOduncKitap.Size = new System.Drawing.Size(457, 271);
            this.dgvOduncKitap.TabIndex = 5;
            this.dgvOduncKitap.SelectionChanged += new System.EventHandler(this.dgvOduncKitap_SelectionChanged);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Location = new System.Drawing.Point(332, 311);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(131, 27);
            this.btnTeslimEt.TabIndex = 4;
            this.btnTeslimEt.Text = "Kitap Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Son Teslim Tarihi";
            // 
            // dtpSonTeslimTarih
            // 
            this.dtpSonTeslimTarih.Location = new System.Drawing.Point(134, 312);
            this.dtpSonTeslimTarih.Name = "dtpSonTeslimTarih";
            this.dtpSonTeslimTarih.Size = new System.Drawing.Size(192, 26);
            this.dtpSonTeslimTarih.TabIndex = 2;
            // 
            // HesabimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKullaniciBilgi);
            this.Name = "HesabimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HesabimForm";
            this.gbKullaniciBilgi.ResumeLayout(false);
            this.gbKullaniciBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKullaniciBilgi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSonTeslimTarih;
        private System.Windows.Forms.DataGridView dgvOduncKitap;
    }
}