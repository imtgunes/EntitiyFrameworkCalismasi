using EntitiyFrameworkCalismasi.Models;
namespace EntitiyFrameworkCalismasi
{
    public partial class Form1 : Form
    {
        public int counter;
        Ogrenci ogr;
        Context context;
        public Form1()
        {
            InitializeComponent();
            context = new Context();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using Context context = new Context();
            dataGridViewOgr.DataSource = context.ogrenci.ToList();


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
            else if (e.ColumnIndex == 13)
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
            else if (e.ColumnIndex == 14)
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
                using Context context = new Context();
                dataGridViewOgr.DataSource = context.ogrenci.ToList();
            }
        }

        private void buttonOgrEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();

        }
    }
}