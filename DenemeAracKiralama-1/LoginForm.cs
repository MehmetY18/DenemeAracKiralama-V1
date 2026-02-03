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
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            VeritabaniBaslat();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;

        }

        

        private void VeritabaniBaslat()
        {
            using (var db = new AppDbContext())
            {
                // Eğer veritabanında hiç kullanıcı yoksa, örnek kullanıcılar ekle
                if (!db.Kullanicilar.Any())
                {
                    // Admin hesabı
                    db.Kullanicilar.Add(new Kullanici
                    {
                        AdSoyad = "Sistem Yöneticisi",
                        KullaniciAdi = "admin",
                        Sifre = "1234",
                        Rol = "Admin"
                    });

                    // Örnek Müşteri hesabı
                    db.Kullanicilar.Add(new Kullanici
                    {
                        AdSoyad = "Mehmet Yücel",
                        KullaniciAdi = "musteri18",
                        Sifre = "1818",
                        Rol = "Musteri"
                    });

                    db.SaveChanges();
                }
            }
        }

        
        

        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            
        }

        //private void materialButton1_Click(object sender, EventArgs e)
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        // Kullanıcıyı veritabanında ara
        //        var kullanici = db.Kullanicilar.FirstOrDefault(u => u.KullaniciAdi == txtkullaniciAdi.Text && u.Sifre == txtSifre.Text);

        //        if (kullanici != null)
        //        {
        //            Oturum.KullaniciID = kullanici.KullaniciID;
        //            Oturum.AdSoyad = kullanici.AdSoyad;
        //            Oturum.Rol = kullanici.Rol;

        //            if (Oturum.Rol == "Admin")
        //            {
        //                // Admin ise AdminPanelForm'u aç
        //                AdminPanelForm adminForm = new AdminPanelForm();
        //                adminForm.Show();
        //            }
        //            else
        //            {
        //                // Müşteri ise Form1'i aç
        //                Form1 musteriForm = new Form1();
        //                musteriForm.Show();
        //            }
        //            this.Hide(); // Login formunu gizle
        //        }
        //        else
        //        {
        //            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
        //        }
        //    }
        //}

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.Hint = "Şifrenizi giriniz..";
            txtSifre.PrefixSuffixText = " ";

        }

        private void txtkullaniciAdi_Click(object sender, EventArgs e)
        {
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Anchor = AnchorStyles.None;

        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Kullanıcıyı veritabanında ara
                var kullanici = db.Kullanicilar.FirstOrDefault(u => u.KullaniciAdi == txtkullaniciAdi.Text && u.Sifre == txtSifre.Text);

                if (kullanici != null)
                {
                    Oturum.KullaniciID = kullanici.KullaniciID;
                    Oturum.AdSoyad = kullanici.AdSoyad;
                    Oturum.Rol = kullanici.Rol;

                    if (Oturum.Rol == "Admin")
                    {
                        // Admin ise AdminPanelForm'u aç
                        AdminPanelForm adminForm = new AdminPanelForm();
                        adminForm.Show();
                        adminForm.BringToFront();
                    }
                    else
                    {
                        // Müşteri ise Form1'i aç
                        Form1 musteriForm = new Form1();
                        musteriForm.Show();
                        musteriForm.BringToFront();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ForgetPassword frm = new ForgetPassword();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
