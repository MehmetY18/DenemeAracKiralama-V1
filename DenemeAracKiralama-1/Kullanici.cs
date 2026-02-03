using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeAracKiralama_1
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; } // "Admin" veya "Musteri"
        public string GizliSoru { get; set; }
        public string GizliYanit { get; set; }
    }
}
