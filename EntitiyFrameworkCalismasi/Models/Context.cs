using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkCalismasi.Models
{
    class Context : DbContext
    {
        public DbSet<Fakulte> fakulte { get; set; }
        public DbSet<Bolum> bolum { get; set; }
        public DbSet<Ogrenci> ogrenci { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P37DUPU;Database=myDataBase;User Id=sa; Password=12345;");
        }
    }

}
