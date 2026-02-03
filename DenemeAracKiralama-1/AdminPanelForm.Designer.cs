namespace DenemeAracKiralama_1
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dvgAdminAraclar = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.lblToplamKazanc = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRaporTablosu = new System.Windows.Forms.DataGridView();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvAdminMusteriler = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminAraclar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporTablosu)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 505);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(45, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dvgAdminAraclar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnTeslimAl);
            this.tabPage1.Controls.Add(this.lblToplamKazanc);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Araç Yönetimi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(676, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 47);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dvgAdminAraclar
            // 
            this.dvgAdminAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAdminAraclar.Location = new System.Drawing.Point(6, 21);
            this.dvgAdminAraclar.Name = "dvgAdminAraclar";
            this.dvgAdminAraclar.Size = new System.Drawing.Size(612, 318);
            this.dvgAdminAraclar.TabIndex = 0;
            this.dvgAdminAraclar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgAdminAraclar_CellFormatting);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Seçili Aracı Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yeni Araç Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(641, 148);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(89, 32);
            this.btnTeslimAl.TabIndex = 2;
            this.btnTeslimAl.Text = "Araç Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // lblToplamKazanc
            // 
            this.lblToplamKazanc.AutoSize = true;
            this.lblToplamKazanc.Location = new System.Drawing.Point(21, 205);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(0, 17);
            this.lblToplamKazanc.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRaporTablosu);
            this.tabPage2.Controls.Add(this.lblToplamGelir);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiralamalar ve Gelir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRaporTablosu
            // 
            this.dgvRaporTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporTablosu.Location = new System.Drawing.Point(6, 21);
            this.dgvRaporTablosu.Name = "dgvRaporTablosu";
            this.dgvRaporTablosu.Size = new System.Drawing.Size(612, 318);
            this.dgvRaporTablosu.TabIndex = 0;
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(109, 358);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(90, 17);
            this.lblToplamGelir.TabIndex = 1;
            this.lblToplamGelir.Text = "Toplam Gelir: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvAdminMusteriler);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Müşteri Yönetimi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAdminMusteriler
            // 
            this.dgvAdminMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminMusteriler.Location = new System.Drawing.Point(6, 21);
            this.dgvAdminMusteriler.Name = "dgvAdminMusteriler";
            this.dgvAdminMusteriler.Size = new System.Drawing.Size(612, 318);
            this.dgvAdminMusteriler.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(632, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "Müşterileri Listele";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 572);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.Resize += new System.EventHandler(this.AdminPanelForm_Resize);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminAraclar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporTablosu)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Label lblToplamKazanc;
        private System.Windows.Forms.DataGridView dvgAdminAraclar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.DataGridView dgvRaporTablosu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvAdminMusteriler;
        private System.Windows.Forms.Button button3;
    }
}