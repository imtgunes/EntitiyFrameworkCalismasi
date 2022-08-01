using EntitiyFrameworkCalismasi.Models;
namespace EntitiyFrameworkCalismasi
{
    public partial class Anasayfa : Form
    {
        public int counter;
        Ogrenci ogr;
        Context context;

        public Anasayfa()
        {
            InitializeComponent();
            context = new Context();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Properties.Settings.Default.ArkaPlanRengi;
            var bilgiler =
                 from ogrnc in context.ogrenci
                 join bol in context.bolum on ogrnc.bolumId equals bol.bolumId
                 join fa in context.fakulte on bol.fakulteId equals fa.fakulteId
                 select new { ogrnc.ogrenciId, ogrnc.ogrenciAdi, ogrnc.ogrenciSoyadi, ogrnc.kimlikNo, ogrnc.ogrenciNo, ogrnc.telefonNo, ogrnc.adres, ogrnc.sinif, ogrnc.dogumTarihi, ogrnc.girisTarihi, bol.bolumAdi, fa.fakulteAdi, ogrnc.bolum, ogrnc.bolumId, ogrnc.donem };
            
            dataGridViewOgr.DataSource = bilgiler.ToList();
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewOgr.Columns.Add(btn);
            btn.HeaderText = "Sil";
            btn.Text = "Sil";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnGuncelle = new DataGridViewButtonColumn();
            dataGridViewOgr.Columns.Add(btnGuncelle);
            btnGuncelle.HeaderText = "Guncelle";
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.UseColumnTextForButtonValue = true;

            this.dataGridViewOgr.Columns["Bolum"].Visible = false;
            this.dataGridViewOgr.Columns["bolumId"].Visible = false;
            this.dataGridViewOgr.Columns["donem"].Visible = false;
            this.dataGridViewOgr.Columns["fakulteAdi"].MinimumWidth = 130;


            dataGridViewBolumler.DataSource = context.bolum.ToList();
            this.dataGridViewBolumler.Columns["Fakulte"].Visible = false;
            dataGridViewFakülteler.DataSource = context.fakulte.ToList();
        }


       
        private void dataGridViewOgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == -1)
            {
                FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[2].Value);
                formOgrenciDetay.Show();
            }
            else if (e.ColumnIndex == 0)
            {
                ogr = context.ogrenci.Find((int)dataGridViewOgr.Rows[e.RowIndex].Cells[2].Value);
                context.ogrenci.Remove(ogr);
                context.SaveChanges();
                MessageBox.Show("Baþarýyla silindi");

            }
            else if (e.ColumnIndex == 15)
            {
                ogr = context.ogrenci.Find((int)dataGridViewOgr.Rows[e.RowIndex].Cells[0].Value);
                context.ogrenci.Remove(ogr);
                context.SaveChanges();
                MessageBox.Show("Baþarýyla silindi");
            }
            else if (e.ColumnIndex == 1 )
            {
                FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[2].Value);
                formOgrenciDetay.Show();
            }
            else if (e.ColumnIndex == 16)
            {
                FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.Rows[e.RowIndex].Cells[0].Value);
                formOgrenciDetay.Show();
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            counter++;
            if(counter > 1)
            {
                this.BackColor = Properties.Settings.Default.ArkaPlanRengi;
                var bilgiler =
                 from ogrnc in context.ogrenci
                 join bol in context.bolum on ogrnc.bolumId equals bol.bolumId
                 join fa in context.fakulte on bol.fakulteId equals fa.fakulteId
                 select new { ogrnc.ogrenciId, ogrnc.ogrenciAdi, ogrnc.ogrenciSoyadi, ogrnc.kimlikNo, ogrnc.ogrenciNo, ogrnc.telefonNo, ogrnc.adres, ogrnc.sinif, ogrnc.dogumTarihi, ogrnc.girisTarihi, bol.bolumAdi, fa.fakulteAdi, ogrnc.bolum, ogrnc.bolumId, ogrnc.donem };
                dataGridViewOgr.DataSource = bilgiler.ToList();
            }
        }

        private void buttonOgrEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
    }
}