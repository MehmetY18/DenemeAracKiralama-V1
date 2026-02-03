using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeAracKiralama_1
{
    public class Arac
    {
        public int AracID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public decimal GunlukUcret { get; set; }
        public string ResimYolu { get; set; }
        public int Durum { get; set; } // 1: Müsait, 2: Kirada, 3: Bakımda
        public string YakitTipi { get; set; } // Benzin, Dizel, Elektrik
        public string VitesTipi { get; set; } // Manuel, Otomatik
        public string KasaTipi { get; set; }  // Sedan, SUV, Hatchback
        public string Kategori { get; set; }
        public int KoltukSayisi { get; set; }
    }
}
