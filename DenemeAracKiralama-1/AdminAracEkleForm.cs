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

        public void Temizle()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            numUcret.Clear();
            txtResimYolu.Clear();
            comboBox1.SelectedIndex = -1;
            txtResimYolu.Clear();

            // İmleci otomatik olarak ilk kutucuğa gönder:
            txtMarka.Focus();
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
            panel1.Top = (this.ClientSize.Width - panel1.Height) / 2;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void AdminAracEkleForm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Width - panel1.Height) / 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                try
                {
                    // Yeni araç nesnesini oluşturuyoruz
                    var yeniArac = new Arac
                    {
                        Marka = txtMarka.Text.Trim(),
                        Model = txtModel.Text.Trim(),
                        Plaka = txtPlaka.Text.Trim(),
                        GunlukUcret = decimal.Parse(numUcret.Text), // NumericUpDown kullanımı
                        ResimYolu = txtResimYolu.Text.Trim(),
                        Kategori = cmbAdminKategori.SelectedItem.ToString(),
                        Durum = 1, // Yeni araç her zaman 'Müsait' eklenir
                        YakitTipi = cmbYakitTipi.Text,
                        VitesTipi = cmbVitesTipi.Text,
                        KasaTipi = cmbKasa.Text,
                        KoltukSayisi = int.Parse(cmbKoltukSayisi.Text)
                    };

                    // Eksik alan kontrolü
                    if (string.IsNullOrEmpty(yeniArac.Marka) || string.IsNullOrEmpty(yeniArac.Plaka))
                    {
                        MessageBox.Show("Lütfen en azından Marka ve Plaka bilgilerini giriniz!");
                        return;
                    }

                    db.Araclar.Add(yeniArac);
                    db.SaveChanges();

                    MessageBox.Show($"{yeniArac.Marka} {yeniArac.Model} başarıyla envantere eklendi.", "Başarılı");

                    // İşlem bittikten sonra formu kapat ve ana listeyi yenilemek için bilgi ver
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydedilirken bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
