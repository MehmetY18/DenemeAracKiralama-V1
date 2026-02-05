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
                var sorgu = db.Araclar.AsQueryable();

                //3. Metin araması varsa süz (marka veya Model içinde geçerse)
                if (!string.IsNullOrEmpty(txtArama.Text))
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
                    UC_AracKart kart = new UC_AracKart(arac);
                    flp.Controls.Add(kart);
                }
            }
            pnlAnaIcerik.Controls.Add(flp);
        }

        public void AraclarıListele()
        {
            flpAraclar.Controls.Clear();

            using (var db = new AppDbContext())
            {
            
                var araclar = db.Araclar.ToList();

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
            pnlUstBar.Top = (this.ClientSize.Width - pnlAnaIcerik.Height) / 2;

        }

       

        private void flpAraclar_Paint(object sender, PaintEventArgs e)
        {

        }

        

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
            DialogResult secim = MessageBox.Show("Giriş ekranına dönmek istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
            if(secim== DialogResult.Yes)
            {
                LoginForm frmLogin = new LoginForm();
                frmLogin.Show();
                this.Close();
            }
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
