namespace EntitiyFrameworkCalismasi
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOgr = new System.Windows.Forms.DataGridView();
            this.buttonOgrEkle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewBolumler = new System.Windows.Forms.DataGridView();
            this.dataGridViewFakülteler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgr)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBolumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFakülteler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgr
            // 
            this.dataGridViewOgr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgr.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOgr.Name = "dataGridViewOgr";
            this.dataGridViewOgr.RowTemplate.Height = 25;
            this.dataGridViewOgr.Size = new System.Drawing.Size(1363, 499);
            this.dataGridViewOgr.TabIndex = 0;
            this.dataGridViewOgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgr_CellClick);
            // 
            // buttonOgrEkle
            // 
            this.buttonOgrEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOgrEkle.Location = new System.Drawing.Point(1277, 545);
            this.buttonOgrEkle.Name = "buttonOgrEkle";
            this.buttonOgrEkle.Size = new System.Drawing.Size(106, 23);
            this.buttonOgrEkle.TabIndex = 1;
            this.buttonOgrEkle.Text = "Ogrenci Ekle";
            this.buttonOgrEkle.UseVisualStyleBackColor = true;
            this.buttonOgrEkle.Click += new System.EventHandler(this.buttonOgrEkle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1371, 527);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewOgr);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1363, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBolumler);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1363, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bölümler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewFakülteler);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1363, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fakülteler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ayarlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewBolumler
            // 
            this.dataGridViewBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBolumler.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBolumler.Name = "dataGridViewBolumler";
            this.dataGridViewBolumler.RowTemplate.Height = 25;
            this.dataGridViewBolumler.Size = new System.Drawing.Size(1357, 496);
            this.dataGridViewBolumler.TabIndex = 0;
            // 
            // dataGridViewFakülteler
            // 
            this.dataGridViewFakülteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFakülteler.Location = new System.Drawing.Point(0, 2);
            this.dataGridViewFakülteler.Name = "dataGridViewFakülteler";
            this.dataGridViewFakülteler.RowTemplate.Height = 25;
            this.dataGridViewFakülteler.Size = new System.Drawing.Size(1363, 497);
            this.dataGridViewFakülteler.TabIndex = 0;
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonOgrEkle);
            this.Name = "OgrenciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgr)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBolumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFakülteler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewOgr;
        private Button buttonOgrEkle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private DataGridView dataGridViewBolumler;
        private DataGridView dataGridViewFakülteler;
    }
}