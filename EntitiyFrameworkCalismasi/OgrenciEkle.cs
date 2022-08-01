using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntitiyFrameworkCalismasi.Models;
namespace EntitiyFrameworkCalismasi
{
    public partial class OgrenciEkle : Form
    {
        Ogrenci yeniOgrenci;
        Context context;

        public OgrenciEkle()
        {
            InitializeComponent();
            context = new Context();
            yeniOgrenci = new Ogrenci();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            yeniOgrenci.kimlikNo = Convert.ToInt32(textBoxOgrKimlikE.Text);
            yeniOgrenci.girisTarihi = dateTimePickerOgrGTarihiE.Value;
            yeniOgrenci.dogumTarihi = dateTimePickerOgrDTarihiE.Value;
            yeniOgrenci.adres = textBoxOgrAdresE.Text;
            yeniOgrenci.bolumId = (int)comboBoxBolumE.SelectedValue;
            yeniOgrenci.ogrenciAdi = textBoxOgrAdE.Text;
            yeniOgrenci.ogrenciSoyadi = textBoxOgrSoyadE.Text;
            yeniOgrenci.ogrenciNo = Convert.ToInt32(textBoxOgrNoE.Text);
            if (!String.IsNullOrEmpty(textBoxOgrTlfNoE.Text))
            {
                yeniOgrenci.telefonNo = Convert.ToInt32(textBoxOgrTlfNoE.Text);
            }
            else
            {
                yeniOgrenci.telefonNo = null;
            }
            
            yeniOgrenci.sinif = Convert.ToInt32(textBoxOgrSınıfE.Text);
            if (radioButton1E.Checked == true)
            {
                yeniOgrenci.donem = 1;
            }
            else
            {
                yeniOgrenci.donem = 0;
            }

            context.ogrenci.Add(yeniOgrenci);
            context.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi");
            this.Close();
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.ArkaPlanRengi;
            this.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), Properties.Settings.Default.FontBoyutu);

            var fakulte = context.fakulte.ToList();
            comboBoxFakulteE.DataSource = fakulte;
            comboBoxFakulteE.DisplayMember = "fakulteAdi";
            comboBoxFakulteE.ValueMember = "fakulteId";

            var bolum = context.bolum.Where(b => b.fakulteId == (int)comboBoxFakulteE.SelectedValue).ToList();
            comboBoxBolumE.DataSource = bolum;
            comboBoxBolumE.DisplayMember = "bolumAdi";
            comboBoxBolumE.ValueMember = "bolumId";
        }

        private void comboBox1E_SelectionChangeCommitted(object sender, EventArgs e)
        {

            var bolum = context.bolum.Where(b => b.fakulteId == (int)comboBoxFakulteE.SelectedValue).ToList();
            comboBoxBolumE.DataSource = bolum;
            comboBoxBolumE.DisplayMember = "bolumAdi";
            comboBoxBolumE.ValueMember = "bolumId";
        }
    }
}
