using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeAracKiralama_1
{
    public partial class UC_AracKart : UserControl
    {
       private Arac _karttakiArac;
        public int SeciliAracID { get; set; }
        public UC_AracKart(Arac arac)
        {
            InitializeComponent();
            _karttakiArac = arac; //Tüm nesneyi sakla
            SeciliAracID = arac.AracID;
            lblBaslik.Text = arac.Marka + " " + arac.Model;
            lblFiyat.Text = $"{arac.GunlukUcret:C2} / Gün";

            // ÖNEMLİ: Resmi kutuya tam sığdırmak için
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!string.IsNullOrEmpty(arac.ResimYolu))
                pbResim.ImageLocation = arac.ResimYolu;
        }

        

        private void UC_AracKart_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SeciliAracID + " ID'li araç kiralama ekranına yönlendiriliyor...");
            KiralamaForm frm = new KiralamaForm(_karttakiArac);
            
            // Eğer kiralama başarıyla biterse (DialogResult.OK dönerse)
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Form1'deki araç listeleme metodunu tekrar çağır
                var anaForm = (Form1)Application.OpenForms["Form1"];
                if (anaForm != null)
                {
                    anaForm.AraclarıListele();
                }
            }
        }
    }
}
