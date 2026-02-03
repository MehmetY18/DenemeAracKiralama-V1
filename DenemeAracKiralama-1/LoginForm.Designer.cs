namespace DenemeAracKiralama_1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtkullaniciAdi);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Location = new System.Drawing.Point(249, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 396);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifremi Unuttum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(165, 334);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(87, 32);
            this.materialButton2.TabIndex = 22;
            this.materialButton2.Text = "Kayıt Ol";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hesabınız yok mu? Kayıt Olun..";
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
            this.txtkullaniciAdi.Location = new System.Drawing.Point(68, 95);
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
            this.txtkullaniciAdi.Size = new System.Drawing.Size(272, 48);
            this.txtkullaniciAdi.TabIndex = 17;
            this.txtkullaniciAdi.TabStop = false;
            this.txtkullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtkullaniciAdi.TrailingIcon = null;
            this.txtkullaniciAdi.UseSystemPasswordChar = false;
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
            this.txtSifre.Location = new System.Drawing.Point(68, 166);
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
            this.txtSifre.Size = new System.Drawing.Size(272, 48);
            this.txtSifre.TabIndex = 18;
            this.txtSifre.TabStop = false;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(165, 248);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(87, 32);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "Giriş";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(3, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 587);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(676, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 587);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DenemeAracKiralama_1.Properties.Resources.hassaan_here_FxNL6fDAvQA_unsplash;
            this.ClientSize = new System.Drawing.Size(916, 654);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kale Rent A Car  | Giriş Ekranı";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtkullaniciAdi;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}