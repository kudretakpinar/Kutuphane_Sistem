
namespace KutuphaneKayit
{
    partial class KayitOlForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayıtAd = new System.Windows.Forms.TextBox();
            this.txtKayıtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.txtKayıtParola = new System.Windows.Forms.TextBox();
            this.txtKayıtParolaTekrar = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblParolaEs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola Tekrar";
            // 
            // txtKayıtAd
            // 
            this.txtKayıtAd.Location = new System.Drawing.Point(192, 51);
            this.txtKayıtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKayıtAd.Name = "txtKayıtAd";
            this.txtKayıtAd.Size = new System.Drawing.Size(143, 30);
            this.txtKayıtAd.TabIndex = 4;
            // 
            // txtKayıtKullanıcıAd
            // 
            this.txtKayıtKullanıcıAd.Location = new System.Drawing.Point(192, 123);
            this.txtKayıtKullanıcıAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKayıtKullanıcıAd.Name = "txtKayıtKullanıcıAd";
            this.txtKayıtKullanıcıAd.Size = new System.Drawing.Size(143, 30);
            this.txtKayıtKullanıcıAd.TabIndex = 5;
            this.txtKayıtKullanıcıAd.TextChanged += new System.EventHandler(this.txtKayıtKullanıcıAd_TextChanged);
            // 
            // txtKayıtParola
            // 
            this.txtKayıtParola.Location = new System.Drawing.Point(192, 184);
            this.txtKayıtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtKayıtParola.Name = "txtKayıtParola";
            this.txtKayıtParola.PasswordChar = '*';
            this.txtKayıtParola.Size = new System.Drawing.Size(143, 30);
            this.txtKayıtParola.TabIndex = 6;
            // 
            // txtKayıtParolaTekrar
            // 
            this.txtKayıtParolaTekrar.Location = new System.Drawing.Point(192, 255);
            this.txtKayıtParolaTekrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtKayıtParolaTekrar.Name = "txtKayıtParolaTekrar";
            this.txtKayıtParolaTekrar.PasswordChar = '*';
            this.txtKayıtParolaTekrar.Size = new System.Drawing.Size(143, 30);
            this.txtKayıtParolaTekrar.TabIndex = 7;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(242, 336);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(104, 40);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // lblParolaEs
            // 
            this.lblParolaEs.AutoSize = true;
            this.lblParolaEs.Location = new System.Drawing.Point(172, 298);
            this.lblParolaEs.Name = "lblParolaEs";
            this.lblParolaEs.Size = new System.Drawing.Size(136, 25);
            this.lblParolaEs.TabIndex = 9;
            this.lblParolaEs.Text = "ParolaCheck";
            this.lblParolaEs.Visible = false;
            // 
            // KayitOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 389);
            this.Controls.Add(this.lblParolaEs);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtKayıtParolaTekrar);
            this.Controls.Add(this.txtKayıtParola);
            this.Controls.Add(this.txtKayıtKullanıcıAd);
            this.Controls.Add(this.txtKayıtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KayitOlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayıtAd;
        private System.Windows.Forms.TextBox txtKayıtKullanıcıAd;
        private System.Windows.Forms.TextBox txtKayıtParola;
        private System.Windows.Forms.TextBox txtKayıtParolaTekrar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblParolaEs;
    }
}