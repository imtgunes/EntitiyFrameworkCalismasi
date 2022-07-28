using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkCalismasi.Models
{
    internal class Ogrenci
    {
        public int ogrenciId { get; set; }
        public string ogrenciAdi { get; set; }
        public string ogrenciSoyadi { get; set; }
        public int kimlikNo { get; set; }
        public int ogrenciNo { get; set; }

        public int telefonNo { get; set; }
        public string adres { get; set; }

        public int donem { get; set; }
        public int sinif { get; set; }

        public DateTime dogumTarihi { get; set; }
        public DateTime girisTarihi { get; set; }

        public int bolumId { get; set; }

        public Bolum bolum { get; set; }
    }
}
