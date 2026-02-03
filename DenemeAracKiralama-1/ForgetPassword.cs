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
    public partial class ForgetPassword : MaterialForm
    {
        private Kullanici _bulunanKullanici;
        public ForgetPassword()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext()) 
            {
                //Kullanıcıyı bulma
                _bulunanKullanici = db.Kullanicilar.FirstOrDefault(u => u.KullaniciAdi == txtkullaniciAdi.Text);

                if (_bulunanKullanici != null)
                {
                    lblGizliSoru.Visible = true;
                    //Kullanıcı bulunduysa gizli soruyu label'a yazalım
                    lblGizliSoru.Text = _bulunanKullanici.GizliSoru;

                    //Gizli yanıt ve yeni şifre alanlarını görünür yap
                    
                    txtYeniSifre.Visible = true;
                    txtGizliSoruCvb.Visible = true;
                    MessageBox.Show("Kullanıcı bulundu! Lütfen gizli soruyu yanıtlayın.");
                }

                else
                {
                    MessageBox.Show("Böyle bir kullanıcı adı kayıtlı değil");
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYeniSifre.Text) || string.IsNullOrWhiteSpace(txtGizliSoruCvb.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }

            using (var db = new AppDbContext())
            {
                //Güvenlik yanıtını kontrol et (Büyük-küçük harf duyarlılığına dikkat!)
                if(_bulunanKullanici.GizliYanit.ToLower() == txtGizliSoruCvb.Text.ToLower())
                {
                    //Veri tabanındaki gerçek kaydı bulup güncelleyelim
                    var guncellenenKullanici = db.Kullanicilar.Find(_bulunanKullanici.KullaniciID);
                    guncellenenKullanici.Sifre = txtYeniSifre.Text;

                    db.SaveChanges();

                    MessageBox.Show("Şifreniz başarıyla sıfırlandı! Giriş ekranına dönebilirsiniz");
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Gizli soru yanıtı hatalı! Lütfen terkar deneyin.");
                }
            }
        }

        private void ForgetPassword_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
