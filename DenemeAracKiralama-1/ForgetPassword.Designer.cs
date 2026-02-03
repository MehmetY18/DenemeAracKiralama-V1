namespace DenemeAracKiralama_1
{
    partial class ForgetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtkullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.lblGizliSoru = new MaterialSkin.Controls.MaterialLabel();
            this.txtGizliSoruCvb = new MaterialSkin.Controls.MaterialTextBox();
            this.txtYeniSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtYeniSifre);
            this.panel1.Controls.Add(this.txtGizliSoruCvb);
            this.panel1.Controls.Add(this.lblGizliSoru);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.txtkullaniciAdi);
            this.panel1.Location = new System.Drawing.Point(107, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 436);
            this.panel1.TabIndex = 0;
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
            this.txtkullaniciAdi.Location = new System.Drawing.Point(102, 60);
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
            this.txtkullaniciAdi.TabIndex = 21;
            this.txtkullaniciAdi.TabStop = false;
            this.txtkullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtkullaniciAdi.TrailingIcon = null;
            this.txtkullaniciAdi.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(200, 138);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(92, 36);
            this.materialButton1.TabIndex = 22;
            this.materialButton1.Text = "Devam et";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(186, 376);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(150, 36);
            this.materialButton2.TabIndex = 23;
            this.materialButton2.Text = "Şifreyi Sıfırla";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // lblGizliSoru
            // 
            this.lblGizliSoru.AutoSize = true;
            this.lblGizliSoru.Depth = 0;
            this.lblGizliSoru.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGizliSoru.Location = new System.Drawing.Point(46, 218);
            this.lblGizliSoru.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGizliSoru.Name = "lblGizliSoru";
            this.lblGizliSoru.Size = new System.Drawing.Size(65, 19);
            this.lblGizliSoru.TabIndex = 24;
            this.lblGizliSoru.Text = "gizli soru";
            this.lblGizliSoru.Visible = false;
            // 
            // txtGizliSoruCvb
            // 
            this.txtGizliSoruCvb.AnimateReadOnly = false;
            this.txtGizliSoruCvb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGizliSoruCvb.Depth = 0;
            this.txtGizliSoruCvb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGizliSoruCvb.LeadingIcon = null;
            this.txtGizliSoruCvb.Location = new System.Drawing.Point(186, 202);
            this.txtGizliSoruCvb.MaxLength = 50;
            this.txtGizliSoruCvb.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGizliSoruCvb.Multiline = false;
            this.txtGizliSoruCvb.Name = "txtGizliSoruCvb";
            this.txtGizliSoruCvb.Size = new System.Drawing.Size(258, 50);
            this.txtGizliSoruCvb.TabIndex = 25;
            this.txtGizliSoruCvb.Text = "";
            this.txtGizliSoruCvb.TrailingIcon = null;
            this.txtGizliSoruCvb.Visible = false;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.AnimateReadOnly = false;
            this.txtYeniSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtYeniSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtYeniSifre.Depth = 0;
            this.txtYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYeniSifre.HideSelection = true;
            this.txtYeniSifre.LeadingIcon = null;
            this.txtYeniSifre.Location = new System.Drawing.Point(102, 281);
            this.txtYeniSifre.MaxLength = 32767;
            this.txtYeniSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '●';
            this.txtYeniSifre.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtYeniSifre.PrefixSuffixText = "Şifre";
            this.txtYeniSifre.ReadOnly = false;
            this.txtYeniSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYeniSifre.SelectedText = "";
            this.txtYeniSifre.SelectionLength = 0;
            this.txtYeniSifre.SelectionStart = 0;
            this.txtYeniSifre.ShortcutsEnabled = true;
            this.txtYeniSifre.Size = new System.Drawing.Size(342, 48);
            this.txtYeniSifre.TabIndex = 26;
            this.txtYeniSifre.TabStop = false;
            this.txtYeniSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYeniSifre.TrailingIcon = null;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            this.txtYeniSifre.Visible = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.panel1);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.Resize += new System.EventHandler(this.ForgetPassword_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtkullaniciAdi;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel lblGizliSoru;
        private MaterialSkin.Controls.MaterialTextBox txtGizliSoruCvb;
        private MaterialSkin.Controls.MaterialTextBox2 txtYeniSifre;
    }
}