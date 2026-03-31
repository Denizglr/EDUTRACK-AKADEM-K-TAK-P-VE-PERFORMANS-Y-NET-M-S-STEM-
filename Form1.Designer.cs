namespace AkademikTakipPerformansYönetimSistemi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvModuller = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModulEkle = new System.Windows.Forms.Button();
            this.txtModulKodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModulSeviye = new System.Windows.Forms.ComboBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModulAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnPerformansKaydet = new System.Windows.Forms.Button();
            this.txtDevamYuzdesi = new System.Windows.Forms.TextBox();
            this.txtOrtalamaNot = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPerformansModulSec = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPerformansOgrenciSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuller)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dgvOgrenciler);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(336, 23);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 24;
            this.dgvOgrenciler.Size = new System.Drawing.Size(418, 369);
            this.dgvOgrenciler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOgrenciEkle);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbDurum);
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİLER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "AKTİF/PASİF";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(128, 201);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(98, 23);
            this.btnOgrenciEkle.TabIndex = 10;
            this.btnOgrenciEkle.Text = "EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 22);
            this.txtID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cmbDurum.Location = new System.Drawing.Point(110, 144);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(137, 24);
            this.cmbDurum.TabIndex = 7;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(110, 98);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(137, 22);
            this.txtBolum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "BÖLÜM";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(110, 57);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(137, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD SOYAD";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvModuller);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eğitim Modülleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvModuller
            // 
            this.dgvModuller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuller.Location = new System.Drawing.Point(338, 26);
            this.dgvModuller.Name = "dgvModuller";
            this.dgvModuller.RowHeadersWidth = 51;
            this.dgvModuller.RowTemplate.Height = 24;
            this.dgvModuller.Size = new System.Drawing.Size(427, 367);
            this.dgvModuller.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnModulEkle);
            this.groupBox2.Controls.Add(this.txtModulKodu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbModulSeviye);
            this.groupBox2.Controls.Add(this.txtSure);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtModulAdi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(27, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODÜLLER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "SEVİYE";
            // 
            // btnModulEkle
            // 
            this.btnModulEkle.Location = new System.Drawing.Point(143, 213);
            this.btnModulEkle.Name = "btnModulEkle";
            this.btnModulEkle.Size = new System.Drawing.Size(101, 23);
            this.btnModulEkle.TabIndex = 21;
            this.btnModulEkle.Text = "KAYDET";
            this.btnModulEkle.UseVisualStyleBackColor = true;
            this.btnModulEkle.Click += new System.EventHandler(this.btnModulEkle_Click);
            // 
            // txtModulKodu
            // 
            this.txtModulKodu.Location = new System.Drawing.Point(119, 27);
            this.txtModulKodu.Name = "txtModulKodu";
            this.txtModulKodu.Size = new System.Drawing.Size(137, 22);
            this.txtModulKodu.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "MODÜL KOD";
            // 
            // cmbModulSeviye
            // 
            this.cmbModulSeviye.FormattingEnabled = true;
            this.cmbModulSeviye.Items.AddRange(new object[] {
            "BAŞLANGIÇ",
            "ORTA",
            "İLERİ"});
            this.cmbModulSeviye.Location = new System.Drawing.Point(119, 147);
            this.cmbModulSeviye.Name = "cmbModulSeviye";
            this.cmbModulSeviye.Size = new System.Drawing.Size(137, 24);
            this.cmbModulSeviye.TabIndex = 18;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(119, 101);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(137, 22);
            this.txtSure.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "SÜRE";
            // 
            // txtModulAdi
            // 
            this.txtModulAdi.Location = new System.Drawing.Point(119, 56);
            this.txtModulAdi.Name = "txtModulAdi";
            this.txtModulAdi.Size = new System.Drawing.Size(137, 22);
            this.txtModulAdi.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "MODÜL AD";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.lblSonuc);
            this.tabPage3.Controls.Add(this.btnPerformansKaydet);
            this.tabPage3.Controls.Add(this.txtDevamYuzdesi);
            this.tabPage3.Controls.Add(this.txtOrtalamaNot);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cmbPerformansModulSec);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmbPerformansOgrenciSec);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Performans Takibi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(45, 318);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 10;
            // 
            // btnPerformansKaydet
            // 
            this.btnPerformansKaydet.Location = new System.Drawing.Point(93, 291);
            this.btnPerformansKaydet.Name = "btnPerformansKaydet";
            this.btnPerformansKaydet.Size = new System.Drawing.Size(167, 23);
            this.btnPerformansKaydet.TabIndex = 8;
            this.btnPerformansKaydet.Text = "HESAPLA ve KAYDET";
            this.btnPerformansKaydet.UseVisualStyleBackColor = true;
            this.btnPerformansKaydet.Click += new System.EventHandler(this.btnPerformansKaydet_Click);
            // 
            // txtDevamYuzdesi
            // 
            this.txtDevamYuzdesi.Location = new System.Drawing.Point(177, 226);
            this.txtDevamYuzdesi.Name = "txtDevamYuzdesi";
            this.txtDevamYuzdesi.Size = new System.Drawing.Size(137, 22);
            this.txtDevamYuzdesi.TabIndex = 7;
            // 
            // txtOrtalamaNot
            // 
            this.txtOrtalamaNot.Location = new System.Drawing.Point(177, 177);
            this.txtOrtalamaNot.Name = "txtOrtalamaNot";
            this.txtOrtalamaNot.Size = new System.Drawing.Size(137, 22);
            this.txtOrtalamaNot.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "DEVAM YÜZDESİ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "ORTALAMA NOT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "MODÜL SEÇİMİ";
            // 
            // cmbPerformansModulSec
            // 
            this.cmbPerformansModulSec.FormattingEnabled = true;
            this.cmbPerformansModulSec.Location = new System.Drawing.Point(177, 122);
            this.cmbPerformansModulSec.Name = "cmbPerformansModulSec";
            this.cmbPerformansModulSec.Size = new System.Drawing.Size(137, 24);
            this.cmbPerformansModulSec.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "ÖĞRENCİ SEÇİMİ";
            // 
            // cmbPerformansOgrenciSec
            // 
            this.cmbPerformansOgrenciSec.FormattingEnabled = true;
            this.cmbPerformansOgrenciSec.Location = new System.Drawing.Point(177, 68);
            this.cmbPerformansOgrenciSec.Name = "cmbPerformansOgrenciSec";
            this.cmbPerformansOgrenciSec.Size = new System.Drawing.Size(137, 24);
            this.cmbPerformansOgrenciSec.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(768, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(768, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(768, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "X";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuller)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvModuller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModulEkle;
        private System.Windows.Forms.TextBox txtModulKodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModulSeviye;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModulAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPerformansModulSec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPerformansOgrenciSec;
        private System.Windows.Forms.TextBox txtDevamYuzdesi;
        private System.Windows.Forms.TextBox txtOrtalamaNot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnPerformansKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
    }
}

