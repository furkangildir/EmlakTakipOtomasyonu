namespace emlakTakipProgramim
{
    partial class ilanlariGor
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
            this.btnFotograflariGor = new System.Windows.Forms.Button();
            this.dgIlanlar = new System.Windows.Forms.DataGrid();
            this.cbIlanTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgIlanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFotograflariGor
            // 
            this.btnFotograflariGor.Location = new System.Drawing.Point(224, 464);
            this.btnFotograflariGor.Name = "btnFotograflariGor";
            this.btnFotograflariGor.Size = new System.Drawing.Size(102, 21);
            this.btnFotograflariGor.TabIndex = 3;
            this.btnFotograflariGor.Text = "Fotografları Göster";
            this.btnFotograflariGor.UseVisualStyleBackColor = true;
            this.btnFotograflariGor.Click += new System.EventHandler(this.btnFotograflariGor_Click);
            // 
            // dgIlanlar
            // 
            this.dgIlanlar.DataMember = "";
            this.dgIlanlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgIlanlar.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgIlanlar.Location = new System.Drawing.Point(0, 0);
            this.dgIlanlar.Name = "dgIlanlar";
            this.dgIlanlar.Size = new System.Drawing.Size(770, 459);
            this.dgIlanlar.TabIndex = 4;
            this.dgIlanlar.CurrentCellChanged += new System.EventHandler(this.dgIlanlar_CurrentCellChanged);
            // 
            // cbIlanTuru
            // 
            this.cbIlanTuru.FormattingEnabled = true;
            this.cbIlanTuru.Items.AddRange(new object[] {
            "Arsa İlanları",
            "İşyeri İlanları",
            "Konut İlanları"});
            this.cbIlanTuru.Location = new System.Drawing.Point(97, 465);
            this.cbIlanTuru.Name = "cbIlanTuru";
            this.cbIlanTuru.Size = new System.Drawing.Size(121, 21);
            this.cbIlanTuru.TabIndex = 1;
            this.cbIlanTuru.SelectedIndexChanged += new System.EventHandler(this.cbIlanTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "İlan Türü:";
            // 
            // ilanlariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgIlanlar);
            this.Controls.Add(this.btnFotograflariGor);
            this.Controls.Add(this.cbIlanTuru);
            this.Name = "ilanlariGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ilanlarıGor";
            this.MaximumSizeChanged += new System.EventHandler(this.ilanlariGor_Load);
            this.Load += new System.EventHandler(this.ilanlariGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIlanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFotograflariGor;
        private System.Windows.Forms.DataGrid dgIlanlar;
        private System.Windows.Forms.ComboBox cbIlanTuru;
        private System.Windows.Forms.Label label1;
    }
}