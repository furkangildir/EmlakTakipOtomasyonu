namespace emlakTakipProgramim
{
    partial class kullaniciBilgiler
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
            this.dgKullanicilar = new System.Windows.Forms.DataGrid();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDgKullaniciYetkisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKullanicilar
            // 
            this.dgKullanicilar.DataMember = "";
            this.dgKullanicilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgKullanicilar.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgKullanicilar.Location = new System.Drawing.Point(0, 0);
            this.dgKullanicilar.Name = "dgKullanicilar";
            this.dgKullanicilar.Size = new System.Drawing.Size(770, 453);
            this.dgKullanicilar.TabIndex = 0;
            this.dgKullanicilar.CurrentCellChanged += new System.EventHandler(this.dgKullanicilar_CurrentCellChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(12, 459);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDgKullaniciYetkisi
            // 
            this.btnDgKullaniciYetkisi.Location = new System.Drawing.Point(102, 459);
            this.btnDgKullaniciYetkisi.Name = "btnDgKullaniciYetkisi";
            this.btnDgKullaniciYetkisi.Size = new System.Drawing.Size(96, 23);
            this.btnDgKullaniciYetkisi.TabIndex = 5;
            this.btnDgKullaniciYetkisi.Text = "Kullanıcı Yetkileri";
            this.btnDgKullaniciYetkisi.UseVisualStyleBackColor = true;
            this.btnDgKullaniciYetkisi.Click += new System.EventHandler(this.brnKullaniciYetkiler_Click);
            // 
            // kullaniciBilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.btnDgKullaniciYetkisi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgKullanicilar);
            this.Name = "kullaniciBilgiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Bilgiler";
            this.Load += new System.EventHandler(this.KullaniciBilgiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgKullanicilar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnDgKullaniciYetkisi;
    }
}