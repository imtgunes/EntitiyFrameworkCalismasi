namespace EntitiyFrameworkCalismasi
{
    partial class Ayarlar
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
            this.buttonArkaPlan = new System.Windows.Forms.Button();
            this.textBoxFontAyarlar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKydtAyarlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArkaPlan
            // 
            this.buttonArkaPlan.Location = new System.Drawing.Point(57, 46);
            this.buttonArkaPlan.Name = "buttonArkaPlan";
            this.buttonArkaPlan.Size = new System.Drawing.Size(186, 23);
            this.buttonArkaPlan.TabIndex = 0;
            this.buttonArkaPlan.Text = "Arka Plan Rengini Değiştir";
            this.buttonArkaPlan.UseVisualStyleBackColor = true;
            this.buttonArkaPlan.Click += new System.EventHandler(this.buttonArkaPlan_Click);
            // 
            // textBoxFontAyarlar
            // 
            this.textBoxFontAyarlar.Location = new System.Drawing.Point(143, 99);
            this.textBoxFontAyarlar.Name = "textBoxFontAyarlar";
            this.textBoxFontAyarlar.Size = new System.Drawing.Size(100, 23);
            this.textBoxFontAyarlar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font Bouyutu:";
            // 
            // buttonKydtAyarlar
            // 
            this.buttonKydtAyarlar.Location = new System.Drawing.Point(713, 415);
            this.buttonKydtAyarlar.Name = "buttonKydtAyarlar";
            this.buttonKydtAyarlar.Size = new System.Drawing.Size(75, 23);
            this.buttonKydtAyarlar.TabIndex = 3;
            this.buttonKydtAyarlar.Text = "Kaydet";
            this.buttonKydtAyarlar.UseVisualStyleBackColor = true;
            this.buttonKydtAyarlar.Click += new System.EventHandler(this.buttonKydtAyarlar_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKydtAyarlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFontAyarlar);
            this.Controls.Add(this.buttonArkaPlan);
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonArkaPlan;
        private TextBox textBoxFontAyarlar;
        private Label label1;
        private Button buttonKydtAyarlar;
    }
}