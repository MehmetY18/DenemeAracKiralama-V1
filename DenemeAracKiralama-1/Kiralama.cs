using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DenemeAracKiralama_1
{
    public class Kiralama
    {
        public int KiralamaID { get; set; }
        public int AracID { get; set; }
        public string MusteriAdSoyad { get; set; }
        public int MusteriID { get; set; }
        public string MusteriTC { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string AlisYeri { get; set; }
        public string TeslimYeri { get; set; }

        

        public string AlisKonumu { get; set; }
        public string TeslimKonumu { get; set; }
        public decimal ToplamUcret { get; set; }
        public virtual Arac Arac { get; set; }

    }
}
