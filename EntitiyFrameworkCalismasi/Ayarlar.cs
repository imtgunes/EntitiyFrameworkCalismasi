using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFrameworkCalismasi
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void buttonArkaPlan_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            Properties.Settings.Default.ArkaPlanRengi = colorDialog.Color;
            Properties.Settings.Default.Save();
            this.BackColor = Properties.Settings.Default.ArkaPlanRengi;
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.ArkaPlanRengi;
        }

        private void buttonKydtAyarlar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFontAyarlar.Text))
            {
                Properties.Settings.Default.FontBoyutu = Convert.ToInt32(textBoxFontAyarlar.Text);
                Properties.Settings.Default.Save();
            }
            
            this.Close();
        }
    }
}
