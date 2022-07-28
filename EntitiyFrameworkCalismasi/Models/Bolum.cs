using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkCalismasi.Models
{
    internal class Bolum
    {
        public int bolumId { get; set; }

        public string bolumAdi { get; set; }
        public int fakulteId { get; set; }
        public Fakulte fakulte { get; set; }

    }
}
