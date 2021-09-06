namespace emlakTakipProgramim
{
    partial class arsaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnArsaEkle = new System.Windows.Forms.Button();
            this.btnSaticiEkle = new System.Windows.Forms.Button();
            this.cbArsaSahibi = new System.Windows.Forms.ComboBox();
            this.cbArsaSatisTipi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIlanBasligi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAidatTutari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.tbMetrekare = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpEklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnFotografEkle = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 534);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnArsaEkle);
            this.tabPage1.Controls.Add(this.btnSaticiEkle);
            this.tabPage1.Controls.Add(this.cbArsaSahibi);
            this.tabPage1.Controls.Add(this.cbArsaSatisTipi);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbIlanBasligi);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.tbAidatTutari);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbIl);
            this.tabPage1.Controls.Add(this.tbFiyat);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.cbIlce);
            this.tabPage1.Controls.Add(this.tbMetrekare);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbAciklama);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbAdres);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.dtpEklenmeTarihi);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arsa Özellikleri Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnArsaEkle
            // 
            this.btnArsaEkle.Location = new System.Drawing.Point(426, 371);
            this.btnArsaEkle.Name = "btnArsaEkle";
            this.btnArsaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnArsaEkle.TabIndex = 176;
            this.btnArsaEkle.Text = "Arsa Ekle";
            this.btnArsaEkle.UseVisualStyleBackColor = true;
            this.btnArsaEkle.Click += new System.EventHandler(this.btnArsaEkle_Click);
            // 
            // btnSaticiEkle
            // 
            this.btnSaticiEkle.Location = new System.Drawing.Point(323, 260);
            this.btnSaticiEkle.Name = "btnSaticiEkle";
            this.btnSaticiEkle.Size = new System.Drawing.Size(21, 23);
            this.btnSaticiEkle.TabIndex = 175;
            this.btnSaticiEkle.Text = "+";
            this.btnSaticiEkle.UseVisualStyleBackColor = true;
            this.btnSaticiEkle.Click += new System.EventHandler(this.btnSaticiEkle_Click);
            // 
            // cbArsaSahibi
            // 
            this.cbArsaSahibi.DropDownHeight = 212;
            this.cbArsaSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArsaSahibi.FormattingEnabled = true;
            this.cbArsaSahibi.IntegralHeight = false;
            this.cbArsaSahibi.Location = new System.Drawing.Point(198, 260);
            this.cbArsaSahibi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArsaSahibi.Name = "cbArsaSahibi";
            this.cbArsaSahibi.Size = new System.Drawing.Size(121, 21);
            this.cbArsaSahibi.TabIndex = 174;
            this.cbArsaSahibi.SelectedIndexChanged += new System.EventHandler(this.cbArsaSahibi_SelectedIndexChanged);
            this.cbArsaSahibi.Click += new System.EventHandler(this.cbArsaSahibi_Click);
            // 
            // cbArsaSatisTipi
            // 
            this.cbArsaSatisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArsaSatisTipi.FormattingEnabled = true;
            this.cbArsaSatisTipi.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cbArsaSatisTipi.Location = new System.Drawing.Point(540, 80);
            this.cbArsaSatisTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArsaSatisTipi.Name = "cbArsaSatisTipi";
            this.cbArsaSatisTipi.Size = new System.Drawing.Size(153, 21);
            this.cbArsaSatisTipi.TabIndex = 166;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 144;
            this.label10.Text = "Arsa Satış Tipi:";
            // 
            // tbIlanBasligi
            // 
            this.tbIlanBasligi.Location = new System.Drawing.Point(198, 48);
            this.tbIlanBasligi.Name = "tbIlanBasligi";
            this.tbIlanBasligi.Size = new System.Drawing.Size(121, 20);
            this.tbIlanBasligi.TabIndex = 169;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 139;
            this.label16.Text = "İlan Başlığı:";
            // 
            // tbAidatTutari
            // 
            this.tbAidatTutari.Location = new System.Drawing.Point(540, 48);
            this.tbAidatTutari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAidatTutari.Name = "tbAidatTutari";
            this.tbAidatTutari.Size = new System.Drawing.Size(153, 20);
            this.tbAidatTutari.TabIndex = 163;
            this.tbAidatTutari.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "İl:";
            // 
            // cbIl
            // 
            this.cbIl.DisplayMember = "-1";
            this.cbIl.DropDownHeight = 212;
            this.cbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIl.FormattingEnabled = true;
            this.cbIl.IntegralHeight = false;
            this.cbIl.Location = new System.Drawing.Point(198, 149);
            this.cbIl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(121, 21);
            this.cbIl.TabIndex = 159;
            this.cbIl.SelectedIndexChanged += new System.EventHandler(this.cbIl_SelectedIndexChanged);
            // 
            // tbFiyat
            // 
            this.tbFiyat.Location = new System.Drawing.Point(198, 83);
            this.tbFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(121, 20);
            this.tbFiyat.TabIndex = 141;
            this.tbFiyat.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(326, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 154;
            this.label23.Text = "TL";
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownHeight = 212;
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.IntegralHeight = false;
            this.cbIlce.Location = new System.Drawing.Point(198, 185);
            this.cbIlce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(121, 21);
            this.cbIlce.TabIndex = 160;
            // 
            // tbMetrekare
            // 
            this.tbMetrekare.Location = new System.Drawing.Point(198, 118);
            this.tbMetrekare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMetrekare.Name = "tbMetrekare";
            this.tbMetrekare.Size = new System.Drawing.Size(121, 20);
            this.tbMetrekare.TabIndex = 157;
            this.tbMetrekare.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(326, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 146;
            this.label21.Text = "m²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "İlçe:";
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(540, 227);
            this.tbAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAciklama.Size = new System.Drawing.Size(153, 100);
            this.tbAciklama.TabIndex = 168;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(56, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 145;
            this.label20.Text = "Metrekare:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 152;
            this.label4.Text = "Adres:";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(540, 111);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdres.Size = new System.Drawing.Size(153, 100);
            this.tbAdres.TabIndex = 162;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 147;
            this.label17.Text = "Fiyat:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(56, 227);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 13);
            this.label26.TabIndex = 151;
            this.label26.Text = "Eklenme Tarihi:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(390, 271);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 148;
            this.label24.Text = "Açıklama:";
            // 
            // dtpEklenmeTarihi
            // 
            this.dtpEklenmeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEklenmeTarihi.Location = new System.Drawing.Point(198, 221);
            this.dtpEklenmeTarihi.Name = "dtpEklenmeTarihi";
            this.dtpEklenmeTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtpEklenmeTarihi.TabIndex = 170;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(56, 263);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 150;
            this.label27.Text = "Arsa Sahibi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 149;
            this.label5.Text = "Aidat Tutarı:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(670, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 161;
            this.label25.Text = "TL";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.btnFotografEkle);
            this.tabPage2.Controls.Add(this.pictureBox11);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arsa Fotoğraf Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(553, 467);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnFotografEkle
            // 
            this.btnFotografEkle.Location = new System.Drawing.Point(464, 467);
            this.btnFotografEkle.Name = "btnFotografEkle";
            this.btnFotografEkle.Size = new System.Drawing.Size(83, 23);
            this.btnFotografEkle.TabIndex = 26;
            this.btnFotografEkle.Text = "Fotoğraf Ekle";
            this.btnFotografEkle.UseVisualStyleBackColor = true;
            this.btnFotografEkle.Click += new System.EventHandler(this.btnFotografEkle_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Location = new System.Drawing.Point(89, 89);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(574, 355);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 16;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(184, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(242, 37);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(300, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(358, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(416, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(474, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            this.ofd.Multiselect = true;
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // arsaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "arsaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arsaForm";
            this.Load += new System.EventHandler(this.satilikArsa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaticiEkle;
        private System.Windows.Forms.ComboBox cbArsaSahibi;
        private System.Windows.Forms.ComboBox cbArsaSatisTipi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIlanBasligi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAidatTutari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.TextBox tbMetrekare;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpEklenmeTarihi;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFotografEkle;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnArsaEkle;
    }
}