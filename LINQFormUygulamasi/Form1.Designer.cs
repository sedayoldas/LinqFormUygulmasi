namespace LINQFormUygulamasi
{
    partial class Form1
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
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.gvUrun = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokluVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrun)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKategori
            // 
            this.cbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(344, 28);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(189, 24);
            this.cbKategori.TabIndex = 0;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // gvUrun
            // 
            this.gvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUrun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvUrun.Location = new System.Drawing.Point(0, 150);
            this.gvUrun.Name = "gvUrun";
            this.gvUrun.Size = new System.Drawing.Size(555, 233);
            this.gvUrun.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // formlarToolStripMenuItem
            // 
            this.formlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çokluVeriToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.güncellemeToolStripMenuItem,
            this.silmeToolStripMenuItem});
            this.formlarToolStripMenuItem.Name = "formlarToolStripMenuItem";
            this.formlarToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.formlarToolStripMenuItem.Text = "Formlar";
            // 
            // çokluVeriToolStripMenuItem
            // 
            this.çokluVeriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.çokluVeriToolStripMenuItem.Name = "çokluVeriToolStripMenuItem";
            this.çokluVeriToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.çokluVeriToolStripMenuItem.Text = "Çoklu Veri";
            this.çokluVeriToolStripMenuItem.Click += new System.EventHandler(this.çokluVeriToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.urunEkleToolStripMenuItem.Text = "Urun Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // güncellemeToolStripMenuItem
            // 
            this.güncellemeToolStripMenuItem.Name = "güncellemeToolStripMenuItem";
            this.güncellemeToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.güncellemeToolStripMenuItem.Text = "Güncelleme";
            this.güncellemeToolStripMenuItem.Click += new System.EventHandler(this.güncellemeToolStripMenuItem_Click);
            // 
            // silmeToolStripMenuItem
            // 
            this.silmeToolStripMenuItem.Name = "silmeToolStripMenuItem";
            this.silmeToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.silmeToolStripMenuItem.Text = "Silme";
            this.silmeToolStripMenuItem.Click += new System.EventHandler(this.silmeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 383);
            this.Controls.Add(this.gvUrun);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUrun)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.DataGridView gvUrun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokluVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silmeToolStripMenuItem;
    }
}

