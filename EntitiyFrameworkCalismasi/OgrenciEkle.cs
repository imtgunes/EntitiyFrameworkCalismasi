﻿using System;
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
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            using Context context = new Context();
            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci.kimlikNo = Convert.ToInt32(textBoxOgrKimlikE.Text);
            yeniOgrenci.girisTarihi = dateTimePickerOgrGTarihiE.Value;
            yeniOgrenci.dogumTarihi = dateTimePickerOgrDTarihiE.Value;
            yeniOgrenci.adres = textBoxOgrAdresE.Text;
            yeniOgrenci.bolumId = (int)comboBox2E.SelectedValue;
            yeniOgrenci.ogrenciAdi = textBoxOgrAdE.Text;
            yeniOgrenci.ogrenciSoyadi = textBoxOgrSoyadE.Text;
            yeniOgrenci.ogrenciNo = Convert.ToInt32(textBoxOgrNoE.Text);
            yeniOgrenci.telefonNo = Convert.ToInt32(textBoxOgrTlfNoE.Text);
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
            using Context context = new Context();
            var fakulte = context.fakulte.ToList();
            comboBox1E.DataSource = fakulte;
            comboBox1E.DisplayMember = "fakulteAdi";
            comboBox1E.ValueMember = "fakulteId";

            var bolum = context.bolum.Where(b => b.fakulteId == (int)comboBox1E.SelectedValue).ToList();
            comboBox2E.DataSource = bolum;
            comboBox2E.DisplayMember = "bolumAdi";
            comboBox2E.ValueMember = "bolumId";
        }

        private void comboBox1E_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using Context context = new Context();

            var bolum = context.bolum.Where(b => b.fakulteId == (int)comboBox1E.SelectedValue).ToList();
            comboBox2E.DataSource = bolum;
            comboBox2E.DisplayMember = "bolumAdi";
            comboBox2E.ValueMember = "bolumId";
        }
    }
}