namespace emlakTakipProgramim
{
    partial class frmIlanlariDuzenle
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
            this.dgIlanlariDuzenle = new System.Windows.Forms.DataGridView();
            this.cbIlanTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKonutEkle = new System.Windows.Forms.Button();
            this.btnSaticiEkle = new System.Windows.Forms.Button();
            this.cbKonutSahibi = new System.Windows.Forms.ComboBox();
            this.cbEsyalimi = new System.Windows.Forms.ComboBox();
            this.cbkonutSatisTipi = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbOdaSayisi = new System.Windows.Forms.ComboBox();
            this.tbIlanBasligi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAidatTutari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.tbMetrekare = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKonutYasi = new System.Windows.Forms.ComboBox();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBulunduguKat = new System.Windows.Forms.ComboBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpEklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbIsitma = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbEmlakYapiTuru = new System.Windows.Forms.ComboBox();
            this.btnFotografDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgIlanlariDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgIlanlariDuzenle
            // 
            this.dgIlanlariDuzenle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIlanlariDuzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgIlanlariDuzenle.Location = new System.Drawing.Point(0, 0);
            this.dgIlanlariDuzenle.Name = "dgIlanlariDuzenle";
            this.dgIlanlariDuzenle.ReadOnly = true;
            this.dgIlanlariDuzenle.Size = new System.Drawing.Size(770, 277);
            this.dgIlanlariDuzenle.TabIndex = 0;
            this.dgIlanlariDuzenle.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIlanlariDuzenle_RowEnter);
            this.dgIlanlariDuzenle.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgIlanlariDuzenle_RowPrePaint);
            // 
            // cbIlanTuru
            // 
            this.cbIlanTuru.FormattingEnabled = true;
            this.cbIlanTuru.Items.AddRange(new object[] {
            "Arsa İlanları",
            "İşyeri İlanları",
            "Konut İlanları"});
            this.cbIlanTuru.Location = new System.Drawing.Point(75, 283);
            this.cbIlanTuru.Name = "cbIlanTuru";
            this.cbIlanTuru.Size = new System.Drawing.Size(121, 21);
            this.cbIlanTuru.TabIndex = 2;
            this.cbIlanTuru.SelectedIndexChanged += new System.EventHandler(this.cbIlanTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlan Türü:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(659, 331);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(659, 362);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKonutEkle
            // 
            this.btnKonutEkle.Location = new System.Drawing.Point(297, 730);
            this.btnKonutEkle.Name = "btnKonutEkle";
            this.btnKonutEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKonutEkle.TabIndex = 215;
            this.btnKonutEkle.Text = "Konut Ekle";
            this.btnKonutEkle.UseVisualStyleBackColor = true;
            // 
            // btnSaticiEkle
            // 
            this.btnSaticiEkle.Location = new System.Drawing.Point(265, 552);
            this.btnSaticiEkle.Name = "btnSaticiEkle";
            this.btnSaticiEkle.Size = new System.Drawing.Size(21, 23);
            this.btnSaticiEkle.TabIndex = 214;
            this.btnSaticiEkle.Text = "+";
            this.btnSaticiEkle.UseVisualStyleBackColor = true;
            this.btnSaticiEkle.Click += new System.EventHandler(this.btnSaticiEkle_Click);
            // 
            // cbKonutSahibi
            // 
            this.cbKonutSahibi.DropDownHeight = 212;
            this.cbKonutSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKonutSahibi.FormattingEnabled = true;
            this.cbKonutSahibi.IntegralHeight = false;
            this.cbKonutSahibi.Location = new System.Drawing.Point(138, 552);
            this.cbKonutSahibi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKonutSahibi.Name = "cbKonutSahibi";
            this.cbKonutSahibi.Size = new System.Drawing.Size(121, 21);
            this.cbKonutSahibi.TabIndex = 213;
            this.cbKonutSahibi.Click += new System.EventHandler(this.cbKonutSahibi_Click);
            // 
            // cbEsyalimi
            // 
            this.cbEsyalimi.DropDownHeight = 212;
            this.cbEsyalimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsyalimi.DropDownWidth = 165;
            this.cbEsyalimi.FormattingEnabled = true;
            this.cbEsyalimi.IntegralHeight = false;
            this.cbEsyalimi.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbEsyalimi.Location = new System.Drawing.Point(138, 377);
            this.cbEsyalimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEsyalimi.Name = "cbEsyalimi";
            this.cbEsyalimi.Size = new System.Drawing.Size(121, 21);
            this.cbEsyalimi.TabIndex = 212;
            // 
            // cbkonutSatisTipi
            // 
            this.cbkonutSatisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkonutSatisTipi.FormattingEnabled = true;
            this.cbkonutSatisTipi.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cbkonutSatisTipi.Location = new System.Drawing.Point(460, 394);
            this.cbkonutSatisTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkonutSatisTipi.Name = "cbkonutSatisTipi";
            this.cbkonutSatisTipi.Size = new System.Drawing.Size(153, 21);
            this.cbkonutSatisTipi.TabIndex = 207;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 457);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 177;
            this.label22.Text = "Oda Sayısı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 196;
            this.label15.Text = "Isıtma:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 185;
            this.label10.Text = "Emlak Satış Tipi:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 407);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 178;
            this.label19.Text = "Emlak Yapı Türü:";
            // 
            // cbOdaSayisi
            // 
            this.cbOdaSayisi.DropDownHeight = 165;
            this.cbOdaSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdaSayisi.FormattingEnabled = true;
            this.cbOdaSayisi.IntegralHeight = false;
            this.cbOdaSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7 ",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14 "});
            this.cbOdaSayisi.Location = new System.Drawing.Point(138, 451);
            this.cbOdaSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOdaSayisi.Name = "cbOdaSayisi";
            this.cbOdaSayisi.Size = new System.Drawing.Size(121, 21);
            this.cbOdaSayisi.TabIndex = 199;
            // 
            // tbIlanBasligi
            // 
            this.tbIlanBasligi.Location = new System.Drawing.Point(138, 328);
            this.tbIlanBasligi.Name = "tbIlanBasligi";
            this.tbIlanBasligi.Size = new System.Drawing.Size(121, 20);
            this.tbIlanBasligi.TabIndex = 210;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 184;
            this.label9.Text = "Bulunduğu Kat:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 180;
            this.label16.Text = "İlan Başlığı:";
            // 
            // tbAidatTutari
            // 
            this.tbAidatTutari.Location = new System.Drawing.Point(460, 320);
            this.tbAidatTutari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAidatTutari.Name = "tbAidatTutari";
            this.tbAidatTutari.Size = new System.Drawing.Size(153, 20);
            this.tbAidatTutari.TabIndex = 204;
            this.tbAidatTutari.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 183;
            this.label8.Text = "Emlak Yaşı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 181;
            this.label2.Text = "İl:";
            // 
            // cbIl
            // 
            this.cbIl.DisplayMember = "-1";
            this.cbIl.DropDownHeight = 212;
            this.cbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIl.FormattingEnabled = true;
            this.cbIl.IntegralHeight = false;
            this.cbIl.Location = new System.Drawing.Point(138, 476);
            this.cbIl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(121, 21);
            this.cbIl.TabIndex = 200;
            this.cbIl.SelectedIndexChanged += new System.EventHandler(this.cbIl_SelectedIndexChanged);
            // 
            // tbFiyat
            // 
            this.tbFiyat.Location = new System.Drawing.Point(138, 353);
            this.tbFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(121, 20);
            this.tbFiyat.TabIndex = 182;
            this.tbFiyat.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(268, 357);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 195;
            this.label23.Text = "TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 179;
            this.label3.Text = "Eşyalı mı?";
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownHeight = 212;
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.IntegralHeight = false;
            this.cbIlce.Location = new System.Drawing.Point(138, 501);
            this.cbIlce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(121, 21);
            this.cbIlce.TabIndex = 201;
            // 
            // tbMetrekare
            // 
            this.tbMetrekare.Location = new System.Drawing.Point(138, 427);
            this.tbMetrekare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMetrekare.Name = "tbMetrekare";
            this.tbMetrekare.Size = new System.Drawing.Size(121, 20);
            this.tbMetrekare.TabIndex = 198;
            this.tbMetrekare.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(268, 430);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 187;
            this.label21.Text = "m²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 194;
            this.label4.Text = "İlçe:";
            // 
            // cbKonutYasi
            // 
            this.cbKonutYasi.DropDownHeight = 165;
            this.cbKonutYasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKonutYasi.FormattingEnabled = true;
            this.cbKonutYasi.IntegralHeight = false;
            this.cbKonutYasi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "50"});
            this.cbKonutYasi.Location = new System.Drawing.Point(460, 344);
            this.cbKonutYasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKonutYasi.Name = "cbKonutYasi";
            this.cbKonutYasi.Size = new System.Drawing.Size(153, 21);
            this.cbKonutYasi.TabIndex = 205;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(460, 550);
            this.tbAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAciklama.Size = new System.Drawing.Size(153, 100);
            this.tbAciklama.TabIndex = 209;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 432);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 186;
            this.label20.Text = "Metrekare:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 193;
            this.label5.Text = "Adres:";
            // 
            // cbBulunduguKat
            // 
            this.cbBulunduguKat.DropDownHeight = 165;
            this.cbBulunduguKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBulunduguKat.FormattingEnabled = true;
            this.cbBulunduguKat.IntegralHeight = false;
            this.cbBulunduguKat.Items.AddRange(new object[] {
            "-2",
            "-1",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "40",
            "50",
            "60"});
            this.cbBulunduguKat.Location = new System.Drawing.Point(460, 369);
            this.cbBulunduguKat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBulunduguKat.Name = "cbBulunduguKat";
            this.cbBulunduguKat.Size = new System.Drawing.Size(153, 21);
            this.cbBulunduguKat.TabIndex = 206;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(460, 446);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdres.Size = new System.Drawing.Size(153, 100);
            this.tbAdres.TabIndex = 203;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 188;
            this.label17.Text = "Fiyat:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 533);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 13);
            this.label26.TabIndex = 192;
            this.label26.Text = "Eklenme Tarihi:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(372, 588);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 189;
            this.label24.Text = "Açıklama:";
            // 
            // dtpEklenmeTarihi
            // 
            this.dtpEklenmeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEklenmeTarihi.Location = new System.Drawing.Point(138, 527);
            this.dtpEklenmeTarihi.Name = "dtpEklenmeTarihi";
            this.dtpEklenmeTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtpEklenmeTarihi.TabIndex = 211;
            // 
            // cbIsitma
            // 
            this.cbIsitma.DropDownHeight = 165;
            this.cbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsitma.DropDownWidth = 185;
            this.cbIsitma.FormattingEnabled = true;
            this.cbIsitma.IntegralHeight = false;
            this.cbIsitma.Items.AddRange(new object[] {
            "Klima",
            "Merkezi Sistem",
            "Güneş Enerjisi",
            "Kombi (Elektrikli)",
            "Isıtma Sistemi Yok",
            "Jeotermal",
            "Kalorifer (Akaryakıt)",
            "Kalorifer (Doğalgaz)",
            "Kalorifer (Kömür)",
            "Kat Kaloriferi (Akaryakıt)",
            "Kombi (Doğalgaz)",
            "Soba (Doğalgaz)",
            "Soba (Kömür)",
            "Yerden Isıtma"});
            this.cbIsitma.Location = new System.Drawing.Point(460, 421);
            this.cbIsitma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsitma.Name = "cbIsitma";
            this.cbIsitma.Size = new System.Drawing.Size(153, 21);
            this.cbIsitma.TabIndex = 208;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 555);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 191;
            this.label27.Text = "İlan Sahibi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 190;
            this.label6.Text = "Aidat Tutarı:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(619, 323);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 202;
            this.label25.Text = "TL";
            // 
            // cbEmlakYapiTuru
            // 
            this.cbEmlakYapiTuru.DropDownHeight = 212;
            this.cbEmlakYapiTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmlakYapiTuru.DropDownWidth = 165;
            this.cbEmlakYapiTuru.FormattingEnabled = true;
            this.cbEmlakYapiTuru.IntegralHeight = false;
            this.cbEmlakYapiTuru.Items.AddRange(new object[] {
            "Akaryakıt İstasyonu",
            "Apartman Dairesi",
            "Atölye",
            "AVM",
            "Büfe",
            "Büro & Ofis",
            "Çiftlik",
            "Depo & Antrepo",
            "Düğün Salonu",
            "Dükkan & Mağaza",
            "Fabrika",
            "İmalathane",
            "İş Hanı Katı & Ofisi",
            "Komple Bina",
            "Otopark (41)",
            "Pazar Yeri (157)",
            "Plaza Katı (885)"});
            this.cbEmlakYapiTuru.Location = new System.Drawing.Point(138, 402);
            this.cbEmlakYapiTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmlakYapiTuru.Name = "cbEmlakYapiTuru";
            this.cbEmlakYapiTuru.Size = new System.Drawing.Size(121, 21);
            this.cbEmlakYapiTuru.TabIndex = 216;
            // 
            // btnFotografDuzenle
            // 
            this.btnFotografDuzenle.Location = new System.Drawing.Point(659, 391);
            this.btnFotografDuzenle.Name = "btnFotografDuzenle";
            this.btnFotografDuzenle.Size = new System.Drawing.Size(99, 23);
            this.btnFotografDuzenle.TabIndex = 217;
            this.btnFotografDuzenle.Text = "Fotoğraf Düzenle";
            this.btnFotografDuzenle.UseVisualStyleBackColor = true;
            this.btnFotografDuzenle.Click += new System.EventHandler(this.btnFotografDuzenle_Click);
            // 
            // frmIlanlariDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 674);
            this.Controls.Add(this.btnFotografDuzenle);
            this.Controls.Add(this.cbEmlakYapiTuru);
            this.Controls.Add(this.btnKonutEkle);
            this.Controls.Add(this.btnSaticiEkle);
            this.Controls.Add(this.cbKonutSahibi);
            this.Controls.Add(this.cbEsyalimi);
            this.Controls.Add(this.cbkonutSatisTipi);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbOdaSayisi);
            this.Controls.Add(this.tbIlanBasligi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbAidatTutari);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIl);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.tbMetrekare);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKonutYasi);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBulunduguKat);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dtpEklenmeTarihi);
            this.Controls.Add(this.cbIsitma);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIlanTuru);
            this.Controls.Add(this.dgIlanlariDuzenle);
            this.Name = "frmIlanlariDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlanları Düzenle";
            this.Load += new System.EventHandler(this.frmIlanlariDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIlanlariDuzenle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgIlanlariDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKonutEkle;
        private System.Windows.Forms.Button btnSaticiEkle;
        private System.Windows.Forms.ComboBox cbKonutSahibi;
        private System.Windows.Forms.ComboBox cbEsyalimi;
        private System.Windows.Forms.ComboBox cbkonutSatisTipi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbOdaSayisi;
        private System.Windows.Forms.TextBox tbIlanBasligi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAidatTutari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.TextBox tbMetrekare;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKonutYasi;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBulunduguKat;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpEklenmeTarihi;
        private System.Windows.Forms.ComboBox cbIsitma;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbEmlakYapiTuru;
        private System.Windows.Forms.Button btnFotografDuzenle;
        public System.Windows.Forms.ComboBox cbIlanTuru;
    }
}