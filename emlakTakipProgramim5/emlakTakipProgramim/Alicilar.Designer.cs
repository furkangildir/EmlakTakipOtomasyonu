namespace emlakTakipProgramim
{
    partial class Alicilar
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
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEmlakTuru = new System.Windows.Forms.ComboBox();
            this.cbIlanBasligi = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgAlicilar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(193, 363);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(123, 20);
            this.tbAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(193, 410);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(123, 20);
            this.tbSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(193, 457);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(123, 20);
            this.tbTelefon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail:";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(425, 363);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(123, 20);
            this.tbMail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emlak Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İlan Başlığı:";
            // 
            // cbEmlakTuru
            // 
            this.cbEmlakTuru.FormattingEnabled = true;
            this.cbEmlakTuru.Items.AddRange(new object[] {
            "Konut",
            "İşyeri",
            "Arsa"});
            this.cbEmlakTuru.Location = new System.Drawing.Point(425, 407);
            this.cbEmlakTuru.Name = "cbEmlakTuru";
            this.cbEmlakTuru.Size = new System.Drawing.Size(121, 21);
            this.cbEmlakTuru.TabIndex = 4;
            this.cbEmlakTuru.SelectedIndexChanged += new System.EventHandler(this.cbEmlakTuru_SelectedIndexChanged);
            // 
            // cbIlanBasligi
            // 
            this.cbIlanBasligi.FormattingEnabled = true;
            this.cbIlanBasligi.Location = new System.Drawing.Point(425, 458);
            this.cbIlanBasligi.Name = "cbIlanBasligi";
            this.cbIlanBasligi.Size = new System.Drawing.Size(121, 21);
            this.cbIlanBasligi.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(599, 384);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(599, 413);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgAlicilar
            // 
            this.dgAlicilar.AllowUserToResizeRows = false;
            this.dgAlicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlicilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgAlicilar.Location = new System.Drawing.Point(0, 0);
            this.dgAlicilar.Name = "dgAlicilar";
            this.dgAlicilar.Size = new System.Drawing.Size(770, 357);
            this.dgAlicilar.TabIndex = 7;
            this.dgAlicilar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlicilar_RowEnter);
            this.dgAlicilar.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgAlicilar_RowPrePaint);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(599, 442);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Alicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgAlicilar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbIlanBasligi);
            this.Controls.Add(this.cbEmlakTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label1);
            this.Name = "Alicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alicilar";
            this.Load += new System.EventHandler(this.Alicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEmlakTuru;
        private System.Windows.Forms.ComboBox cbIlanBasligi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgAlicilar;
        private System.Windows.Forms.Button btnSil;
    }
}