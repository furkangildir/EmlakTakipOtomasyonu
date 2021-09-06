namespace emlakTakipProgramim
{
    partial class KullaniciYetkiler
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
            this.dgKullanicilar.Size = new System.Drawing.Size(770, 450);
            this.dgKullanicilar.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(12, 456);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // KullaniciYetkiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 491);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgKullanicilar);
            this.Name = "KullaniciYetkiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciDuzenle";
            this.Load += new System.EventHandler(this.KullaniciDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgKullanicilar;
        private System.Windows.Forms.Button btnGuncelle;
    }
}