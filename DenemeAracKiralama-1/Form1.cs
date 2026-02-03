using MaterialSkin.Controls;
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


namespace DenemeAracKiralama_1
{
    public partial class Form1 : MaterialForm
    {


        
        private void Filtrele()
        {
            //1. Ekrandaki mevcut kartları temizle
            flpAraclar.Controls.Clear();
            using(var db = new AppDbContext())
            {
                //2.Veritabanından temel sorguyu oluştur(sadece müsait olanlar)
                var sorgu = db.Araclar.Where(a => a.Durum == 1).AsQueryable();

                //3. Metin araması varsa süz (marka veya Model içinde geçerse)
                if(!string.IsNullOrEmpty(txtArama.Text))
                {
                    string ara = txtArama.Text.ToLower();
                    sorgu = sorgu.Where(a => a.Marka.ToLower().Contains(ara) || a.Model.ToLower().Contains(ara));
                }

                //4.Kategori seçiliyse süz

                if(cmbKategori.SelectedIndex > 0) //:0 Tüm araçlar ise süzme yapmaz 
                {
                    string secilenKategori = cmbKategori.SelectedItem.ToString();
                    sorgu = sorgu.Where(a => a.Kategori == secilenKategori);
                }
                //5. Sonuçları listeye çevir ve kartları oluştur
                foreach(var arac in sorgu.ToList())
                {
                    UC_AracKart kart = new UC_AracKart(arac);
                    flpAraclar.Controls.Add(kart);

                }
            }
        }

        //public void AdminAracListesiGuncelle()
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        // Admin her şeyi görmeli (Müsait mi, Bakımda mı?)
        //        var tumAraclar = db.Araclar.ToList();
        //        dgvAdminAraclar.DataSource = tumAraclar;
        //    }
        //}

        //public void AdminVerileriniYukle()
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        // Veritabanındaki tüm araçları listeliyoruz
        //        var aracListesi = db.Araclar.ToList();

        //        // DataGridView'a bağlarken verileri daha şık gösterelim (Anonymous Type)
        //        dgvAdminAraclar.DataSource = aracListesi.Select(a => new
        //        {
        //            ID = a.AracID,
        //            Marka = a.Marka,
        //            Model = a.Model,
        //            Plaka = a.Plaka,
        //            Ücret = a.GunlukUcret.ToString("C2"), // Para birimi formatı (TL)
        //            Durum = a.Durum == 1 ? "Müsait" : (a.Durum == 2 ? "Kirada" : "Bakımda")
        //        }).ToList();

        //        // Tablo başlıklarını güzelleştirelim
        //        dgvAdminAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    }
        //}

        //private void ArayuzuSekillendir()
        //{
        //    if (_isAdmin)
        //    {
        //        flpAraclar.Visible = false;      // Kartları gizle
        //        dgvAdminAraclar.Visible = true; // Tabloyu göster
        //        this.Text = "RentACar - YÖNETİCİ PANELİ";
        //        btnAracEkle.Visible = true;
        //        btnMusteriListesi.Visible = true;
        //        pnlUstBar.BackColor = Color.Maroon; // Admin olduğunu belli etsin
        //    }
        //    else
        //    {
        //        flpAraclar.Visible = true;       // Kartları göster
        //        dgvAdminAraclar.Visible = false; // Tabloyu gizle
        //        AraclarıListele();              // Kartları doldur
        //        this.Text = "RentACar - Hoş Geldiniz";
        //        btnAracEkle.Visible = false; // Müşteri araç ekleyemez
        //        btnMusteriListesi.Visible = false; // Müşteri diğer müşterileri göremez
        //        pnlUstBar.BackColor = Color.FromArgb(255, 117, 23);
        //        pnlAnaIcerik.BackColor = Color.FromArgb(255,255,255);
        //        pnlSolBar.BackColor = Color.FromArgb(62,57,57);

        //        // Müşteri açılır açılmaz araç listesini görsün
        //        //MusteriAracListesiniYukle();
        //    }
        //}

        public void MusteriAracListesiniYukle()
        {
            pnlAnaIcerik.Controls.Clear(); // Önce temizle

            // FlowLayoutPanel: Kartları yan yana dizmek için en iyisidir
            this.Text = "Araç Filosu";
            
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;
            flp.AutoScroll = true;

            using (var db = new AppDbContext())
            {
                var araclar = db.Araclar.Where(x => x.Durum == 1).ToList();

                foreach (var arac in araclar)
                {
                    // Burada her araç için bir 'UC_AracKart' (User Control) 
                    // oluşturup flp.Controls.Add(kart) diyeceğiz.
                }
            }
            pnlAnaIcerik.Controls.Add(flp);
        }

        public void AraclarıListele()
        {
            flpAraclar.Controls.Clear();

            using (var db = new AppDbContext())
            {
                // Sadece durumu "Müsait" (1) olan araçları getiriyoruz
                var araclar = db.Araclar.Where(a => a.Durum == 1).ToList();

                foreach (var arac in araclar)
                {
                    // Her araç için yeni bir UserControl (Kart) oluştur
                    UC_AracKart kart = new UC_AracKart(arac);

                    // Kartı panelin içine ekle
                    flpAraclar.Controls.Add(kart);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            AraclarıListele();
            cmbKategori.SelectedIndex = 0;
            pnlAnaIcerik.Left = (this.ClientSize.Width - pnlAnaIcerik.Width) / 2;
            pnlAnaIcerik.Top = (this.ClientSize.Height - pnlAnaIcerik.Height) / 2;
            pnlUstBar.Left = (this.ClientSize.Width - pnlAnaIcerik.Width) / 2;
            pnlUstBar.Top = (this.ClientSize.Width - pnlAnaIcerik.Width) / 2;

        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        // Sadece 'Musteri' rolündeki kişileri göster
        //        var musteriler = db.Kullanicilar.Where(u => u.Rol == "Musteri").ToList();
        //        dgvAdminAraclar.DataSource = musteriler;
        //    }
        //}

        private void flpAraclar_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnAracEkle_Click(object sender, EventArgs e)
        //{
        //    AdminAracEkleForm frm = new AdminAracEkleForm();

        //    // Formu modal olarak aç (kapatılana kadar ana forma geçilmez)
        //    if (frm.ShowDialog() == DialogResult.OK)
        //    {
        //        // Araç eklendiyse listeyi hemen tazele
        //        if (_isAdmin)
        //            AdminVerileriniYukle(); // Grid'i yenile
        //        else
        //            AraclarıListele(); // Kartları yenile
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKiralamaListesi frm = new MusteriKiralamaListesi();
            // Formun içine metodu çağıran bir kod ekleyebilirsin veya açılışta Load olayına koyabilirsin
            frm.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnlAnaIcerik.Left = (this.ClientSize.Width - pnlAnaIcerik.Width) / 2;
            pnlAnaIcerik.Top = (this.ClientSize.Height - pnlAnaIcerik.Height) / 2;
            pnlUstBar.Left = (this.ClientSize.Width - pnlAnaIcerik.Width) / 2;
            pnlUstBar.Top = (this.ClientSize.Width - pnlAnaIcerik.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
