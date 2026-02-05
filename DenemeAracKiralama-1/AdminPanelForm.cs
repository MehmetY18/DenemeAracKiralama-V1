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
using Microsoft.EntityFrameworkCore;


namespace DenemeAracKiralama_1
{
    public partial class AdminPanelForm : MaterialForm
    {
        public AdminPanelForm()
        {
            InitializeComponent();
                
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }

        public void VerileriYukle()
        {
            using (var db = new AppDbContext())
            {
               
                // Sadece db.Araclar'ı çektiğimizden emin oluyoruz.
                var araclar = db.Araclar.ToList();

                var aracListesi = araclar.Select(a => new {
                    a.AracID,
                    a.Marka,
                    a.Model,
                    a.Plaka,
                    a.GunlukUcret,
                    // Durum bilgisini metne çeviriyoruz
                    DurumMetin = a.Durum == 1 ? "MÜSAİT" : (a.Durum == 2 ? "KİRADA" : "BAKIMDA"),
                    DurumKod = a.Durum
                }).ToList();

                // Sadece Araçlar tablosuna (Mavi olan) bu listeyi veriyoruz
                dvgAdminAraclar.DataSource = null;
                dvgAdminAraclar.DataSource = aracListesi;

                if (dvgAdminAraclar.Columns["DurumKod"] != null)
                    dvgAdminAraclar.Columns["DurumKod"].Visible = false;

                dvgAdminAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        


        public void RaporuGuncelle()
        {
            dgvRaporTablosu.Columns.Clear();
            using (var db = new AppDbContext())
            {
                var liste = db.Kiralamalar
                    .Include(k => k.Arac) // Aracı çekmek zorundayız çünkü Marka/Model orada
                    .Select(k => new {
                        ID = k.KiralamaID,
                        Müşteri = k.MusteriAdSoyad, 
                        Araç = k.Arac.Marka + " " + k.Arac.Model,
                        Tarih = k.AlisTarihi,
                        Gelir = k.ToplamUcret
                    }).ToList();

                dgvRaporTablosu.DataSource = null;
                dgvRaporTablosu.DataSource = liste;

                // Gelir label'ını da doğru isme (lblToplamGelir) yazdırıyoruz
                decimal toplam = db.Kiralamalar.Sum(k => (decimal?)k.ToplamUcret) ?? 0;
                lblToplamGelir.Text = string.Format("Toplam Gelir: {0:C2}", toplam);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
           
            VerileriYukle();
            RaporuGuncelle();
            

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dvgAdminAraclar.CurrentRow != null)
            {
                int aracId = (int)dvgAdminAraclar.CurrentRow.Cells["AracID"].Value;
                using (var db = new AppDbContext())
                {
                    // 1. Aracı bulalım
                    var arac = db.Araclar.Find(aracId);

                    if (arac != null)
                    {
                        // 2. Bu araca ait olan ve henüz silinmemiş kiralamayı bulalım
                        var kiralamaKaydi = db.Kiralamalar.FirstOrDefault(k => k.AracID == aracId);

                        if (kiralamaKaydi != null)
                        {
                            // Kiralamayı silerek listeyi temizleyelim
                            db.Kiralamalar.Remove(kiralamaKaydi);
                        }

                        // 3. Aracı tekrar müsait yap
                        arac.Durum = 1;

                        db.SaveChanges();

                        MessageBox.Show("Araç teslim alındı ve kiralama kaydı başarıyla kapatıldı!");

                        // 4. Hem araç listesini hem de müşteri/gelir listesini yenile
                        VerileriYukle(); // Araç listesini yeniler
                        if (Application.OpenForms["AdminForm"] != null)
                        {
                            // Eğer rapor metodun varsa onu da burada tetikleyebilirsin
                        }
                    }
                }
            }
        }

        

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        // Sadece 'Musteri' rolündeki kişileri göster
        //        var musteriler = db.Kullanicilar.Where(u => u.Rol == "Musteri").ToList();
        //        dgvAdminMusteriler.DataSource = musteriler;
                
        //    }
        //}

        private void dvgAdminAraclar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                string deger = e.Value.ToString();

                if (deger == "MÜSAİT")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (deger == "KİRADA")
                {
                    e.CellStyle.BackColor = Color.Salmon;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (deger == "BAKIMDA")
                {
                    e.CellStyle.BackColor = Color.Gold;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void dvgAdminAraclar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Hata penceresinin çıkmasını engellemek için burayı boş bırakıyoruz.
            // DataGridView bir hata yakaladığında hiçbir şey yapmayacak.
            //e.ThrowException = false;
            e.Cancel = true; // Hata mesajını tamamen engeller ve işlemin devam etmesini sağlar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAracEkleForm frm = new AdminAracEkleForm();
            frm.ShowDialog();
            // Ekleme formu kapandığı anda aşağıdaki satırlar çalışır:
            VerileriYukle();
            RaporuGuncelle();


        }

        private void AdminPanelForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            using (var db = new AppDbContext())
            {
                var testListe = db.Kiralamalar.ToList();
                if (testListe.Count > 0)
                {
                    // İlk kaydın verisini kontrol edelim
                    var ilkKayit = testListe[0];
                    MessageBox.Show($"Veritabanındaki İlk Kayıt:\nTC: '{ilkKayit.MusteriTC}'\nİsim: '{ilkKayit.MusteriAdSoyad}'");
                }

                // 1. Kiralamalar tablosundan gerçek müşteri verilerini alıyoruz
                var kiralamaMusterileri = db.Kiralamalar
                    .Select(k => new
                    {
                        KiralamaID = k.KiralamaID,
                        TC_Kimlik = k.MusteriTC,
                        Müşteri_Adı = k.MusteriAdSoyad
                    })
                    .Where(k => !string.IsNullOrEmpty(k.Müşteri_Adı)) // Sadece adı dolu olanları getir
                    .Distinct() // Aynı kişi 5 araç kiraladıysa listede 5 kere görünmesin
                    .ToList();

                // 2. Tabloyu tertemiz yapalım
                dgvAdminMusteriler.DataSource = null;
                dgvAdminMusteriler.Columns.Clear();
                dgvAdminMusteriler.AutoGenerateColumns = true;

                // 3. Veriyi yükle
                dgvAdminMusteriler.DataSource = kiralamaMusterileri;
                dgvAdminMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 4. Küçük bir kontrol mesajı
                if (kiralamaMusterileri.Count == 0)
                {
                    MessageBox.Show("Sistemde kayıtlı kiralama (müşteri) verisi bulunamadı!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Giriş ekranına dönmek istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secim == DialogResult.Yes)
            {
                LoginForm frmLogin = new LoginForm();
                frmLogin.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Onay butonu (Yanlışııkla basılma ihtimaline karşı)
            DialogResult onay = MessageBox.Show("Bu aracı silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Araç Silme", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(onay == DialogResult.Yes)
            {
                try
                {
                    using(var db = new AppDbContext())
                    {
                        // Seçili olan aracı ID üzerinden buluyoruz
                        int seciliId = int.Parse(dvgAdminAraclar.CurrentRow.Cells["AracID"].Value.ToString());
                        var silinecekArac = db.Araclar.FirstOrDefault(a => a.AracID  == seciliId);

                        if(silinecekArac != null)
                        {
                            db.Araclar.Remove(silinecekArac);
                            db.SaveChanges();

                            MessageBox.Show("Araç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VerileriYukle();
                            RaporuGuncelle();
                        }
                    }

                }
                catch (Exception)
                {

                    // Eğer araç bir kiralama işlemine dahilse SQL hata verir, burada yakalıyoruz.
                    MessageBox.Show("Bu araç kiralama geçmişinde kayıtlı olduğu için silinemez! Bunun yerine durumunu 'Pasif' yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
