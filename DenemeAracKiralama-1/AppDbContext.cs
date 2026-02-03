using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeAracKiralama_1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=RentACarConn") { }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        
    }
}
