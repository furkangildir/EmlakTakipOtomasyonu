namespace emlakTakipProgramim
{
    partial class saticilariGor
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
            this.dgSaticilar = new System.Windows.Forms.DataGrid();
            this.btnIlanlarınıGor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaticilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSaticilar
            // 
            this.dgSaticilar.DataMember = "";
            this.dgSaticilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSaticilar.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSaticilar.Location = new System.Drawing.Point(0, 0);
            this.dgSaticilar.Name = "dgSaticilar";
            this.dgSaticilar.Size = new System.Drawing.Size(349, 489);
            this.dgSaticilar.TabIndex = 0;
            this.dgSaticilar.CurrentCellChanged += new System.EventHandler(this.dgSaticilar_CurrentCellChanged);
            // 
            // btnIlanlarınıGor
            // 
            this.btnIlanlarınıGor.Location = new System.Drawing.Point(0, 466);
            this.btnIlanlarınıGor.Name = "btnIlanlarınıGor";
            this.btnIlanlarınıGor.Size = new System.Drawing.Size(75, 23);
            this.btnIlanlarınıGor.TabIndex = 1;
            this.btnIlanlarınıGor.Text = "İlanlarını Gör";
            this.btnIlanlarınıGor.UseVisualStyleBackColor = true;
            this.btnIlanlarınıGor.Click += new System.EventHandler(this.btnIlanlarınıGor_Click);
            // 
            // saticilariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 489);
            this.Controls.Add(this.btnIlanlarınıGor);
            this.Controls.Add(this.dgSaticilar);
            this.Name = "saticilariGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saticilariGor";
            this.Load += new System.EventHandler(this.saticilariGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaticilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgSaticilar;
        private System.Windows.Forms.Button btnIlanlarınıGor;
    }
}