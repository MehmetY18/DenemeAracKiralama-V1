namespace DenemeAracKiralama_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSolBar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlUstBar = new System.Windows.Forms.Panel();
            this.pnlAnaIcerik = new System.Windows.Forms.Panel();
            this.flpAraclar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtArama = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbKategori = new MaterialSkin.Controls.MaterialComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSolBar.SuspendLayout();
            this.pnlUstBar.SuspendLayout();
            this.pnlAnaIcerik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSolBar
            // 
            this.pnlSolBar.BackColor = System.Drawing.Color.White;
            this.pnlSolBar.Controls.Add(this.button3);
            this.pnlSolBar.Controls.Add(this.button1);
            this.pnlSolBar.Controls.Add(this.button2);
            this.pnlSolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolBar.Location = new System.Drawing.Point(3, 64);
            this.pnlSolBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSolBar.Name = "pnlSolBar";
            this.pnlSolBar.Size = new System.Drawing.Size(150, 513);
            this.pnlSolBar.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(22, 162);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ayarlar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(22, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kiralamalar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlUstBar
            // 
            this.pnlUstBar.BackColor = System.Drawing.Color.White;
            this.pnlUstBar.Controls.Add(this.cmbKategori);
            this.pnlUstBar.Controls.Add(this.txtArama);
            this.pnlUstBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBar.Location = new System.Drawing.Point(153, 64);
            this.pnlUstBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUstBar.Name = "pnlUstBar";
            this.pnlUstBar.Size = new System.Drawing.Size(818, 81);
            this.pnlUstBar.TabIndex = 1;
            // 
            // pnlAnaIcerik
            // 
            this.pnlAnaIcerik.BackColor = System.Drawing.Color.White;
            this.pnlAnaIcerik.Controls.Add(this.flpAraclar);
            this.pnlAnaIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnaIcerik.Location = new System.Drawing.Point(153, 145);
            this.pnlAnaIcerik.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAnaIcerik.Name = "pnlAnaIcerik";
            this.pnlAnaIcerik.Size = new System.Drawing.Size(818, 432);
            this.pnlAnaIcerik.TabIndex = 2;
            // 
            // flpAraclar
            // 
            this.flpAraclar.AutoScroll = true;
            this.flpAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAraclar.Location = new System.Drawing.Point(0, 0);
            this.flpAraclar.Margin = new System.Windows.Forms.Padding(2);
            this.flpAraclar.Name = "flpAraclar";
            this.flpAraclar.Size = new System.Drawing.Size(818, 432);
            this.flpAraclar.TabIndex = 5;
            this.flpAraclar.Paint += new System.Windows.Forms.PaintEventHandler(this.flpAraclar_Paint);
            // 
            // txtArama
            // 
            this.txtArama.AnimateReadOnly = false;
            this.txtArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtArama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtArama.Depth = 0;
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtArama.HideSelection = true;
            this.txtArama.Hint = "Marka veya Model Ara..";
            this.txtArama.LeadingIcon = null;
            this.txtArama.Location = new System.Drawing.Point(287, 16);
            this.txtArama.MaxLength = 32767;
            this.txtArama.MouseState = MaterialSkin.MouseState.OUT;
            this.txtArama.Name = "txtArama";
            this.txtArama.PasswordChar = '\0';
            this.txtArama.PrefixSuffixText = null;
            this.txtArama.ReadOnly = false;
            this.txtArama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArama.SelectedText = "";
            this.txtArama.SelectionLength = 0;
            this.txtArama.SelectionStart = 0;
            this.txtArama.ShortcutsEnabled = true;
            this.txtArama.Size = new System.Drawing.Size(250, 48);
            this.txtArama.TabIndex = 0;
            this.txtArama.TabStop = false;
            this.txtArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtArama.TrailingIcon = null;
            this.txtArama.UseSystemPasswordChar = false;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.AutoResize = false;
            this.cmbKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbKategori.Depth = 0;
            this.cmbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbKategori.DropDownHeight = 174;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.DropDownWidth = 121;
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.IntegralHeight = false;
            this.cmbKategori.ItemHeight = 43;
            this.cmbKategori.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Ekonomik",
            "Konfor",
            "Lüks"});
            this.cmbKategori.Location = new System.Drawing.Point(586, 15);
            this.cmbKategori.MaxDropDownItems = 4;
            this.cmbKategori.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(153, 49);
            this.cmbKategori.StartIndex = 0;
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(22, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 47);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 580);
            this.Controls.Add(this.pnlAnaIcerik);
            this.Controls.Add(this.pnlUstBar);
            this.Controls.Add(this.pnlSolBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kale Rent A Car | Araç Filosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlSolBar.ResumeLayout(false);
            this.pnlUstBar.ResumeLayout(false);
            this.pnlAnaIcerik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSolBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlUstBar;
        private System.Windows.Forms.Panel pnlAnaIcerik;
        private System.Windows.Forms.FlowLayoutPanel flpAraclar;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialTextBox2 txtArama;
        private MaterialSkin.Controls.MaterialComboBox cmbKategori;
    }
}

