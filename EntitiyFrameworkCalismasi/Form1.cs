using EntitiyFrameworkCalismasi.Models;
namespace EntitiyFrameworkCalismasi
{
    public partial class Form1 : Form
    {
        public int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using Context context = new Context();
            dataGridViewOgr.DataSource = context.ogrenci.ToList();
        }

       

        private void dataGridViewOgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOgr.SelectedRows.Count > 0 && dataGridViewOgr.SelectedRows[0].Cells[1].Value != null)
            {
                
                FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay((int)dataGridViewOgr.SelectedRows[0].Cells[0].Value);
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
    }
}