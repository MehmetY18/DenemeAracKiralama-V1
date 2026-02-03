using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DenemeAracKiralama_1
{
    public partial class MusteriKiralamaListesi : MaterialForm
    {
        public MusteriKiralamaListesi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }
        

        public void KiraladiklarimiListele(int musteriId)
        {
            using (var db = new AppDbContext())
            {
                // Sadece oturum açan kullanıcıya ait kiralamaları getir
                var liste = db.Kiralamalar
                    .Where(k => k.MusteriID == Oturum.KullaniciID)
                    .Select(k => new {
                        Plaka = k.Arac.Plaka,
                        Araç = k.Arac.Marka + " " + k.Arac.Model,
                        Alış = k.AlisTarihi,
                        Teslim = k.TeslimTarihi,
                        Ücret = k.ToplamUcret
                    }).ToList();

                dgvMusteriListe.DataSource = liste;
            }
        }

        private void MusteriKiralamaListesi_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Sadece giriş yapan kullanıcının ID'sine göre filtrele
                var benimKiralamalarim = db.Kiralamalar
                    .Where(k => k.MusteriID == Oturum.KullaniciID)
                    .Select(k => new {
                        Araç = k.Arac.Marka + " " + k.Arac.Model,
                        Başlangıç = k.AlisTarihi,
                        Bitiş = k.TeslimTarihi,
                        Ödenen = k.ToplamUcret
                    }).ToList();

                dgvMusteriListe.DataSource = benimKiralamalarim;
            }

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MusteriKiralamaListesi_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
