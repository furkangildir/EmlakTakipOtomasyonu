namespace emlakTakipProgramim
{
    partial class Kullanicilar
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
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKullanicilar
            // 
            this.dgKullanicilar.DataMember = "";
            this.dgKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKullanicilar.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgKullanicilar.Location = new System.Drawing.Point(0, 0);
            this.dgKullanicilar.Name = "dgKullanicilar";
            this.dgKullanicilar.Size = new System.Drawing.Size(520, 489);
            this.dgKullanicilar.TabIndex = 0;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 489);
            this.Controls.Add(this.dgKullanicilar);
            this.Name = "Kullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgKullanicilar;
    }
}