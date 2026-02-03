namespace DenemeAracKiralama_1
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtkullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAdSoyad = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGizliSoru = new MaterialSkin.Controls.MaterialComboBox();
            this.txtGizliYanit = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(169, 373);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(87, 32);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "Kayıt Ol";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.HideSelection = true;
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(43, 215);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtSifre.PrefixSuffixText = "Şifre";
            this.txtSifre.ReadOnly = false;
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(342, 48);
            this.txtSifre.TabIndex = 21;
            this.txtSifre.TabStop = false;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtkullaniciAdi
            // 
            this.txtkullaniciAdi.AnimateReadOnly = false;
            this.txtkullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtkullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtkullaniciAdi.Depth = 0;
            this.txtkullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtkullaniciAdi.HideSelection = true;
            this.txtkullaniciAdi.LeadingIcon = null;
            this.txtkullaniciAdi.Location = new System.Drawing.Point(43, 144);
            this.txtkullaniciAdi.MaxLength = 32767;
            this.txtkullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtkullaniciAdi.Name = "txtkullaniciAdi";
            this.txtkullaniciAdi.PasswordChar = '\0';
            this.txtkullaniciAdi.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtkullaniciAdi.PrefixSuffixText = "Kullanıcı Adı";
            this.txtkullaniciAdi.ReadOnly = false;
            this.txtkullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtkullaniciAdi.SelectedText = "";
            this.txtkullaniciAdi.SelectionLength = 0;
            this.txtkullaniciAdi.SelectionStart = 0;
            this.txtkullaniciAdi.ShortcutsEnabled = true;
            this.txtkullaniciAdi.Size = new System.Drawing.Size(342, 48);
            this.txtkullaniciAdi.TabIndex = 20;
            this.txtkullaniciAdi.TabStop = false;
            this.txtkullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtkullaniciAdi.TrailingIcon = null;
            this.txtkullaniciAdi.UseSystemPasswordChar = false;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AnimateReadOnly = false;
            this.txtAdSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAdSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdSoyad.Depth = 0;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdSoyad.HideSelection = true;
            this.txtAdSoyad.LeadingIcon = null;
            this.txtAdSoyad.Location = new System.Drawing.Point(43, 76);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtAdSoyad.PrefixSuffixText = "Ad Soyad";
            this.txtAdSoyad.ReadOnly = false;
            this.txtAdSoyad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.SelectionLength = 0;
            this.txtAdSoyad.SelectionStart = 0;
            this.txtAdSoyad.ShortcutsEnabled = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(342, 48);
            this.txtAdSoyad.TabIndex = 22;
            this.txtAdSoyad.TabStop = false;
            this.txtAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdSoyad.TrailingIcon = null;
            this.txtAdSoyad.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGizliYanit);
            this.panel1.Controls.Add(this.cmbGizliSoru);
            this.panel1.Controls.Add(this.txtAdSoyad);
            this.panel1.Controls.Add(this.txtkullaniciAdi);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Location = new System.Drawing.Point(216, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 421);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbGizliSoru
            // 
            this.cmbGizliSoru.AutoResize = false;
            this.cmbGizliSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGizliSoru.Depth = 0;
            this.cmbGizliSoru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGizliSoru.DropDownHeight = 174;
            this.cmbGizliSoru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGizliSoru.DropDownWidth = 121;
            this.cmbGizliSoru.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGizliSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGizliSoru.FormattingEnabled = true;
            this.cmbGizliSoru.IntegralHeight = false;
            this.cmbGizliSoru.ItemHeight = 43;
            this.cmbGizliSoru.Items.AddRange(new object[] {
            "Beyaz",
            "Kahverengi",
            "Kırmızı",
            "Lacivert",
            "Mavi",
            "Mor",
            "Pembe",
            "Sarı",
            "Turuncu",
            "Yeşil"});
            this.cmbGizliSoru.Location = new System.Drawing.Point(169, 287);
            this.cmbGizliSoru.MaxDropDownItems = 4;
            this.cmbGizliSoru.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGizliSoru.Name = "cmbGizliSoru";
            this.cmbGizliSoru.Size = new System.Drawing.Size(216, 49);
            this.cmbGizliSoru.StartIndex = 0;
            this.cmbGizliSoru.TabIndex = 23;
            // 
            // txtGizliYanit
            // 
            this.txtGizliYanit.AutoSize = true;
            this.txtGizliYanit.Depth = 0;
            this.txtGizliYanit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGizliYanit.Location = new System.Drawing.Point(22, 307);
            this.txtGizliYanit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGizliYanit.Name = "txtGizliYanit";
            this.txtGizliYanit.Size = new System.Drawing.Size(123, 19);
            this.txtGizliYanit.TabIndex = 24;
            this.txtGizliYanit.Text = "En Sevdiğin Renk";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 557);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Resize += new System.EventHandler(this.RegisterForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private MaterialSkin.Controls.MaterialTextBox2 txtkullaniciAdi;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdSoyad;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel txtGizliYanit;
        private MaterialSkin.Controls.MaterialComboBox cmbGizliSoru;
    }
}