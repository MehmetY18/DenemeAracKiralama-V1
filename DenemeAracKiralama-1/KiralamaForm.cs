using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations.Schema;

namespace DenemeAracKiralama_1
{
    public partial class KiralamaForm : MaterialForm
    {
        Arac _seciliArac; // Form genelinde kullanmak için
        public KiralamaForm(Arac gelenArac)
        {
            InitializeComponent();
            _seciliArac = gelenArac;
            BilgileriDoldur();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }

        private void BilgileriDoldur()
        {
            lblBaslik.Text = $"{_seciliArac.Marka} {_seciliArac.Model}";
            lblOzellikler.Text = $"⛽ Yakıt: {_seciliArac.YakitTipi}\n" +
                             $"⚙️ Vites: {_seciliArac.VitesTipi}\n" +
                             $"🚗 Kasa: {_seciliArac.KasaTipi}\n" +
                             $"👥 {_seciliArac.KoltukSayisi} Kişilik";
            lblGunlukFiyat.Text = $"{_seciliArac.GunlukUcret:C2}";
            pbAracResim.ImageLocation = _seciliArac.ResimYolu;
            pbAracResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TarihDegisti(object sender, EventArgs e)
        {
            int gun = (dtpTeslimTarihi.Value - dtpAlisTarihi.Value).Days;
            if (gun <= 0) gun = 1;

            decimal toplam = gun * _seciliArac.GunlukUcret;
            lblToplamTutar.Text = $"Toplam: {toplam:C2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        


        private void FiyatHesapla()
        {
            //Gün farkını hesapla
            TimeSpan fark = dtpTeslimTarihi.Value.Date - dtpAlisTarihi.Value.Date;
            int gun = (int)fark.TotalDays;

            //Eğer teslim tarihi alışla aynıysa veya önceyse en az 1 gün say 
            if(gun<=0) gun = 1;

            decimal toplam = gun * _seciliArac.GunlukUcret;
            lblToplamTutar.Text = $"Toplam Gün: {gun} \n Toplam Tutar: {toplam:C2}";
        }

        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            BilgileriDoldur();
            using (var db = new AppDbContext())
            {
                // 1. Bu aracın yapılmış olan en son kiralamasını bulalım (Teslim tarihine bakarak)
                var sonKiralama = db.Kiralamalar
                    .Where(k => k.AracID == _seciliArac.AracID)
                    .OrderByDescending(k => k.TeslimTarihi)
                    .FirstOrDefault();

                // 2. Eğer araç daha önce kiralanmışsa
                if (sonKiralama != null)
                {
                    // Müşteri en erken, aracın teslim edileceği günden 1 gün sonrasını seçebilsin
                    // Eğer teslim tarihi geçmişte kalmışsa bugünü baz alalım
                    DateTime limitTarihi = sonKiralama.TeslimTarihi > DateTime.Now
                                           ? sonKiralama.TeslimTarihi.AddDays(1)
                                           : DateTime.Now;

                    dtpAlisTarihi.MinDate = limitTarihi;
                    dtpTeslimTarihi.MinDate = limitTarihi.AddDays(1);
                }
                else
                {
                    // Araç yeniyse/hiç kiralanmadıysa bugünden öncesini seçemesin
                    dtpAlisTarihi.MinDate = DateTime.Now;
                    dtpTeslimTarihi.MinDate = DateTime.Now.AddDays(1);
                }
            }

            
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            
        }



        private void btnOnaylaVeKirala_Click(object sender, EventArgs e)
        {

            if (!cardOzet.Visible)
            {
                MessageBox.Show("Lütfen önce tarih seçimi yapınız!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTcKimlikNo.Text))

            {
                MessageBox.Show("Lütfen TC Kimlik numaranızı giriniz!", "Uyarı");
                return;
            }



            if (dtpTeslimTarihi.Value <= dtpAlisTarihi.Value)

            {
                MessageBox.Show("Teslim tarihi, alış tarihinden sonra olmalıdır!", "Uyarı");
                return;
            }

            

            using (var db = new AppDbContext())
            {
                try
                {
                    // 1. Önce veritabanından bu kullanıcının diğer bilgilerini (TC gibi) alalım
                    var suAnkiKullanici = db.Kullanicilar.Find(Oturum.KullaniciID);
                    // 2. Yeni Kiralama Nesnesini Doldur

                    Kiralama yeniKiralama = new Kiralama
                    {
                        AracID = _seciliArac.AracID,
                        
                        MusteriID = Oturum.KullaniciID, // Kimin kiraladığı (ID)
                        
                        // İŞTE BURADA OTURUM VE DB BİLGİLERİNİ BİRLEŞTİRİYORUZ
                        MusteriAdSoyad = Oturum.AdSoyad, // Oturum'dan gelen isim

                        MusteriTC = txtTcKimlikNo.Text,

                        AlisTarihi = dtpAlisTarihi.Value,

                        TeslimTarihi = dtpTeslimTarihi.Value,

                        AlisYeri = cmbAlisYeri.Text,

                        TeslimYeri = cmbTeslimYeri.Text,

                        ToplamUcret = (decimal)((dtpTeslimTarihi.Value - dtpAlisTarihi.Value).TotalDays * (double)_seciliArac.GunlukUcret)

                    };



                    if (yeniKiralama.ToplamUcret <= 0)

                        yeniKiralama.ToplamUcret = _seciliArac.GunlukUcret; // En az 1 günlük para al



                    // ... Ücret kontrolü ve Araç durum güncelleme aynı kalıyor ...

                    var kiralananArac = db.Araclar.Find(_seciliArac.AracID);



                    if (kiralananArac != null)

                    {

                        // 2. Aracın durumunu 2 (Kirada) yapıyoruz

                        kiralananArac.Durum = 2;

                    }



                    db.Kiralamalar.Add(yeniKiralama);

                    db.SaveChanges();



                    MessageBox.Show("Kiralama başarıyla kaydedildi!", "Başarılı");

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                }

                catch (Exception ex)

                {

                    MessageBox.Show("Hata: " + ex.Message);

                }

            }

        }
                
        

        private void KiralamaForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void T(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpTeslimTarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark = dtpTeslimTarihi.Value - dtpAlisTarihi.Value;
            int gun = (int)fark.TotalDays;
            if (gun <= 0) gun = 1;

            // 2. Ücret hesapla
            decimal toplam = gun * _seciliArac.GunlukUcret;

            // 3. Kartın içindeki Label'ları doldur
            lblOzetArac.Text = $"{_seciliArac.Marka} {_seciliArac.Model}";
            lblOzetGun.Text = $"{gun} Gün";
            lblOzetToplamTutar.Text = $"{toplam:C2}";

            // 4. Kartı GÖSTER!
            cardOzet.Visible = true;
        }

        private void dtpAlisTarihi_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
