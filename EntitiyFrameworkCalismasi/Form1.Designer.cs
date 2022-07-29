namespace EntitiyFrameworkCalismasi
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgr
            // 
            this.dataGridViewOgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgr.Location = new System.Drawing.Point(32, 12);
            this.dataGridViewOgr.Name = "dataGridViewOgr";
            this.dataGridViewOgr.RowTemplate.Height = 25;
            this.dataGridViewOgr.Size = new System.Drawing.Size(756, 271);
            this.dataGridViewOgr.TabIndex = 0;
            this.dataGridViewOgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgr_CellClick);
            // 
            // buttonOgrEkle
            // 
            this.buttonOgrEkle.Location = new System.Drawing.Point(37, 338);
            this.buttonOgrEkle.Name = "buttonOgrEkle";
            this.buttonOgrEkle.Size = new System.Drawing.Size(106, 23);
            this.buttonOgrEkle.TabIndex = 1;
            this.buttonOgrEkle.Text = "Ogrenci Ekle";
            this.buttonOgrEkle.UseVisualStyleBackColor = true;
            this.buttonOgrEkle.Click += new System.EventHandler(this.buttonOgrEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOgrEkle);
            this.Controls.Add(this.dataGridViewOgr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewOgr;
        private Button buttonOgrEkle;
    }
}