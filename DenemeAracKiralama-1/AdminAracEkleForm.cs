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
    public partial class AdminAracEkleForm : MaterialForm
    {
        public AdminAracEkleForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            this.Width = 900;
            this.Height = 600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Araç Resmi Seç";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Dosyanın tam yolunu TextBox'a yazar
                txtResimYolu.Text = ofd.FileName;
            }
        }

        private void AdminAracEkleForm_Load(object sender, EventArgs e)
        {
            
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void AdminAracEkleForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Width) / 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // 1. Yeni bir araç nesnesi oluşturuyoruz
                    var yeniArac = new Arac
                    {
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Plaka = txtPlaka.Text,
                        GunlukUcret = decimal.Parse(numUcret.Text),
                        Durum = 1, // Yeni eklenen araç varsayılan olarak "Müsait" (1) olsun
                        ResimYolu = txtResimYolu.Text // Seçtiğin resmin dosya yolu
                    };

                    // 2. Veritabanına ekleme komutu
                    db.Araclar.Add(yeniArac);

                    // 3. Değişiklikleri SQL'e kaydet
                    db.SaveChanges();

                    MessageBox.Show("Araç başarıyla sisteme eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
