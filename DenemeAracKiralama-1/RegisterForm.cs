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
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using ( var db = new AppDbContext())
            {
                if(db.Kullanicilar.Any(u => u.KullaniciAdi == txtkullaniciAdi.Text))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten alınmış!");
                    return;
                }

                Kullanici yeniKullanici = new Kullanici
                {
                    AdSoyad = txtAdSoyad.Text,
                    KullaniciAdi = txtkullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Rol = "Musteri" //Varsayılan Rol
                };

                db.Kullanicilar.Add(yeniKullanici);
                db.SaveChanges();
                MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşmiştir! Giriş yapabilirsiniz.");
                this.Close();
            }
        }

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
