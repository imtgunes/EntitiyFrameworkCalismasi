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
    public partial class FormOgrenciDetay : Form
    {
        public int ogrID;
        public FormOgrenciDetay(int ogrID)
        {
            InitializeComponent();
            this.ogrID = ogrID;
        }

        private void FormOgrenciDetay_Load(object sender, EventArgs e)
        {
            using Context context = new Context();
            var ogr = context.ogrenci.Find(ogrID);
            textBoxOgrAd.Text = ogr.ogrenciAdi;
            textBoxOgrNo.Text = ogr.ogrenciNo.ToString();
            textBoxOgrSoyad.Text = ogr.ogrenciSoyadi;
            textBoxOgrKimlik.Text = ogr.kimlikNo.ToString();
            textBoxOgrAdres.Text = ogr.adres;
            textBoxOgrTlfNo.Text = ogr.telefonNo.ToString();
            textBoxOgrSınıf.Text = ogr.sinif.ToString();
            dateTimePickerOgrDTarihi.Value = ogr.dogumTarihi;
            dateTimePickerOgrGTarihi.Value = ogr.girisTarihi;
            if(ogr.donem == 1){
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            var bolumler = context.bolum.Find(ogr.bolumId);
            

            var fakulte = context.fakulte.ToList();
            comboBox1.DataSource = fakulte;
            comboBox1.DisplayMember = "fakulteAdi";
            comboBox1.ValueMember = "fakulteId";

            comboBox1.SelectedValue = bolumler.fakulteId;

            var bolum = context.bolum.Where(b => b.fakulteId == (int)comboBox1.SelectedValue).ToList();
            comboBox2.DataSource = bolum;
            comboBox2.DisplayMember = "bolumAdi";
            comboBox2.ValueMember = "bolumId";

            comboBox2.SelectedValue = ogr.bolumId;


        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            using Context context = new Context();
            var ogr = context.ogrenci.Find(ogrID);
            ogr.ogrenciAdi = textBoxOgrAd.Text;
            ogr.ogrenciSoyadi = textBoxOgrSoyad.Text;
            ogr.ogrenciNo = Convert.ToInt32(textBoxOgrNo.Text);
            ogr.kimlikNo = Convert.ToInt32(textBoxOgrKimlik.Text);
            ogr.adres = textBoxOgrAdres.Text;
            ogr.telefonNo = Convert.ToInt32(textBoxOgrTlfNo.Text);
            ogr.sinif = Convert.ToInt32(textBoxOgrSınıf.Text);
            ogr.dogumTarihi = dateTimePickerOgrDTarihi.Value;
            ogr.girisTarihi = dateTimePickerOgrGTarihi.Value;

            if (radioButton1.Checked == true)
            {
                ogr.donem = 1;
            }
            else
            {
                ogr.donem = 0;
            }
            
            ogr.bolumId = (int)comboBox2.SelectedValue; 

            context.SaveChanges();

            MessageBox.Show("Başarıyla Kaydedildi");

            this.Close();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            using Context context = new Context();
            var ogr = context.ogrenci.Find(ogrID);
            context.ogrenci.Remove(ogr);
            context.SaveChanges();
            MessageBox.Show("Başarıyla silindi");
            this.Close();

        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using Context context = new Context();

            var bolum = context.bolum.Where(b => b.fakulteId == (int)comboBox1.SelectedValue).ToList();
            comboBox2.DataSource = bolum;
            comboBox2.DisplayMember = "bolumAdi";
            comboBox2.ValueMember = "bolumId";
        }
    }
}
