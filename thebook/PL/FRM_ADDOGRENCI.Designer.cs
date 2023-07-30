
namespace thebook.PL
{
    partial class FRM_ADDOGRENCI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDOGRENCI));
            this.Lb_Title = new System.Windows.Forms.Label();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtOgrenciTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOgrenciSoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenci = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtOgrenciTarih = new System.Windows.Forms.DateTimePicker();
            this.txtOgrenciNO = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb_Title.Location = new System.Drawing.Point(288, 3);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(244, 75);
            this.Lb_Title.TabIndex = 5;
            this.Lb_Title.Text = "Öğrenci";
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(781, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 6;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // txtOgrenciTel
            // 
            this.txtOgrenciTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOgrenciTel.BackColor = System.Drawing.Color.White;
            this.txtOgrenciTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOgrenciTel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOgrenciTel.HintForeColor = System.Drawing.Color.Empty;
            this.txtOgrenciTel.HintText = "telefon no";
            this.txtOgrenciTel.isPassword = false;
            this.txtOgrenciTel.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOgrenciTel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOgrenciTel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOgrenciTel.LineThickness = 4;
            this.txtOgrenciTel.Location = new System.Drawing.Point(232, 357);
            this.txtOgrenciTel.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtOgrenciTel.Name = "txtOgrenciTel";
            this.txtOgrenciTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOgrenciTel.Size = new System.Drawing.Size(353, 32);
            this.txtOgrenciTel.TabIndex = 5;
            this.txtOgrenciTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOgrenciSoyad.BackColor = System.Drawing.Color.White;
            this.txtOgrenciSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOgrenciSoyad.HintForeColor = System.Drawing.Color.Empty;
            this.txtOgrenciSoyad.HintText = "soyad";
            this.txtOgrenciSoyad.isPassword = false;
            this.txtOgrenciSoyad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOgrenciSoyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOgrenciSoyad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOgrenciSoyad.LineThickness = 4;
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(232, 244);
            this.txtOgrenciSoyad.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(353, 32);
            this.txtOgrenciSoyad.TabIndex = 3;
            this.txtOgrenciSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(51, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kayıt Tarih";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(51, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefon No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Soyadı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOgrenciAd.BackColor = System.Drawing.Color.White;
            this.txtOgrenciAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOgrenciAd.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOgrenciAd.HintForeColor = System.Drawing.Color.Empty;
            this.txtOgrenciAd.HintText = "adı";
            this.txtOgrenciAd.isPassword = false;
            this.txtOgrenciAd.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOgrenciAd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOgrenciAd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOgrenciAd.LineThickness = 4;
            this.txtOgrenciAd.Location = new System.Drawing.Point(232, 179);
            this.txtOgrenciAd.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOgrenciAd.Size = new System.Drawing.Size(353, 32);
            this.txtOgrenciAd.TabIndex = 2;
            this.txtOgrenciAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.ActiveBorderThickness = 1;
            this.btnOgrenci.ActiveCornerRadius = 20;
            this.btnOgrenci.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOgrenci.ActiveForecolor = System.Drawing.Color.White;
            this.btnOgrenci.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOgrenci.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOgrenci.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOgrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.BackgroundImage")));
            this.btnOgrenci.ButtonText = "Ekleme";
            this.btnOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenci.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOgrenci.IdleBorderThickness = 1;
            this.btnOgrenci.IdleCornerRadius = 20;
            this.btnOgrenci.IdleFillColor = System.Drawing.Color.White;
            this.btnOgrenci.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOgrenci.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOgrenci.Location = new System.Drawing.Point(178, 507);
            this.btnOgrenci.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(458, 50);
            this.btnOgrenci.TabIndex = 7;
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtOgrenciTarih
            // 
            this.txtOgrenciTarih.Enabled = false;
            this.txtOgrenciTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciTarih.Location = new System.Drawing.Point(232, 422);
            this.txtOgrenciTarih.Name = "txtOgrenciTarih";
            this.txtOgrenciTarih.Size = new System.Drawing.Size(353, 31);
            this.txtOgrenciTarih.TabIndex = 6;
            // 
            // txtOgrenciNO
            // 
            this.txtOgrenciNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOgrenciNO.BackColor = System.Drawing.Color.White;
            this.txtOgrenciNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOgrenciNO.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOgrenciNO.HintForeColor = System.Drawing.Color.Empty;
            this.txtOgrenciNO.HintText = "öğrenci No";
            this.txtOgrenciNO.isPassword = false;
            this.txtOgrenciNO.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOgrenciNO.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOgrenciNO.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOgrenciNO.LineThickness = 4;
            this.txtOgrenciNO.Location = new System.Drawing.Point(232, 114);
            this.txtOgrenciNO.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtOgrenciNO.Name = "txtOgrenciNO";
            this.txtOgrenciNO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOgrenciNO.Size = new System.Drawing.Size(353, 32);
            this.txtOgrenciNO.TabIndex = 1;
            this.txtOgrenciNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(51, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(51, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Bölüm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBolum
            // 
            this.txtBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.FormattingEnabled = true;
            this.txtBolum.Items.AddRange(new object[] {
            "Acil Yardım ve Afet Yönetimi",
            "Adalet (MYO)",
            "Adli Bilimler",
            "Adli Bilişim Mühendisliği",
            "Ağız ve Diş Sağlığı (MYO)",
            "Aile ve Tüketici Bilimleri",
            "Aktüerya",
            "Aktüerya Bilimleri",
            "Alman Dili ve Edebiyatı",
            "Almanca Öğretmenliği",
            "Ameliyathane Hizmetleri",
            "Amerikan Kültürü ve Edebiyatı",
            "Anestezi (MYO)",
            "Animasyon ve Oyun Tasarımı",
            "Antrenörlük Eğitimi",
            "Antropoloji",
            "Arap Dili ve Edebiyatı",
            "Arapça Öğretmenliği",
            "Arıcılık (MYO)",
            "Arkeoloji",
            "Arkeoloji ve Sanat Tarihi",
            "Arnavut Dili ve Edebiyatı",
            "Astronomi ve Uzay Bilimleri",
            "Aşçılık (MYO)",
            "Avrupa Birliği İlişkileri",
            "Ayakkabı Tasarımı (MYO)",
            "Azerbaycan Dili Öğretmenliği",
            "Bahçe Bitkileri",
            "Bahçe Bitkileri Üretimi ve Pazarlaması",
            "Balıkçılık Teknolojisi Mühendisliği",
            "Bankacılık",
            "Bankacılık ve Finans",
            "Bankacılık ve Sigortacılık",
            "Basım Teknolojileri",
            "Basın ve Yayın",
            "Baskı Sanatları",
            "Batı Dilleri",
            "Beden Eğitimi ve Spor Öğretmenliği",
            "Beslenme ve Diyetetik",
            "Bilgi Güvenliği Teknolojileri",
            "Bilgi ve Belge Yönetimi",
            "Bilgisayar - Enformatik",
            "Bilgisayar Bilimleri",
            "Bilgisayar Mühendisliği",
            "Bilgisayar Programcılığı",
            "Bilgisayar Teknolojisi ve Bilişim Sistemleri",
            "Bilim Tarihi",
            "Bilişim Sistemleri Mühendisliği",
            "Bilişim Sistemleri ve Teknolojileri",
            "Bitki Koruma",
            "Bitkisel Üretim ve Teknolojileri",
            "Biyoenformatik ve Genetik",
            "Biyokimya",
            "Biyoloji",
            "Biyoloji Öğretmenliği",
            "Biyomedikal Cihaz Teknolojisi (MYO)",
            "Biyomedikal Mühendisliği",
            "Biyomühendislik",
            "Biyosistem Mühendisliği",
            "Biyoteknoloji",
            "Boşnak Dili ve Edebiyatı",
            "Bulgar Dili ve Edebiyatı",
            "Büro Yönetimi ve Sekreterlik (MYO)",
            "Ebelik",
            "Eczacılık",
            "Eczane Hizmetleri (MYO)",
            "Ekonometri",
            "Ekonomi",
            "Ekonomi ve Finans",
            "El Sanatları",
            "Elektrik Mühendisliği",
            "Elektrik/Elektronik Mühendisliği",
            "Elektronik Haberleşme (MYO)",
            "Elektronik Mühendisliği",
            "Elektronik Ticaret ve Teknoloji Yönetimi",
            "Emlak ve Emlak Yönetimi (MYO)",
            "Endüstri Mühendisliği",
            "Endüstri Ürünleri Tasarımı",
            "Endüstriyel Tasarım Mühendisliği",
            "Enerji Sistemleri Mühendisliği",
            "Enerji ve Malzeme Mühendisliği",
            "Enerji Yönetimi",
            "Engelli Bakımı ve Rehabilitasyon",
            "Ergoterapi",
            "Fars Dili ve Edebiyatı",
            "Felsefe",
            "Felsefe Grubu Öğretmenliği",
            "Fen Bilgisi Öğretmenliği",
            "Film Tasarımı ve Yönetmenliği",
            "Finansal Ekonometri",
            "Fizik",
            "Fizik Mühendisliği",
            "Fizik Öğretmenliği",
            "Fizik Tedavi ve Rehabilitasyon",
            "Fotoğraf ve Video",
            "Fotoğrafçılık ve Kameramanlık (MYO)",
            "Fransız Dili ve Edebiyatı",
            "Fransızca Öğretmenliği",
            "Gastronomi ve Mutfak Sanatları",
            "Gayrimenkul Değerleme",
            "Gazetecilik",
            "Geleneksel El Sanatları (MYO)",
            "Gemi İnşaatı (MYO)",
            "Gemi İnşaatı ve Gemi Makineleri Mühendisliği",
            "Gemi ve Deniz Teknolojisi Mühendisliği",
            "Genetik ve Biyomühendislik",
            "Geomatik Mühendisliği",
            "Gerontoloji",
            "Gıda Mühendisliği",
            "Gıda Teknolojisi (MYO)",
            "Görsel İletişim Tasarımı",
            "Görsel Sanatlar ve Görsel İletişim Tasarımı",
            "Grafik Tasarımı",
            "Gümrük İşletme",
            "Gürcü Dili ve Edebiyatı",
            "Güverte",
            "Güzel Sanatlar",
            "Halkla İlişkiler",
            "Halkla İlişkiler ve Reklamcılık",
            "Halkla İlişkiler ve Tanıtım",
            "Harita Mühendisliği",
            "Havacılık Elektrik ve Elektroniği",
            "Havacılık ve Uzay Mühendisliği",
            "Havacılık Yönetimi",
            "Hayvansal Üretim",
            "Hemşirelik",
            "Hemşirelik ve Sağlık Hizmetleri",
            "Heykel",
            "Hidrojeoloji Mühendisliği",
            "Hukuk",
            "İbrani Dili ve Edebiyatı",
            "İç Mekan Tasarımı",
            "İç Mimarlık",
            "İç Mimarlık ve Çevre Tasarımı",
            "İlahiyat",
            "İletişim Bilimleri",
            "İletişim Sanatları",
            "İletişim Tasarımı",
            "İletişim Tasarımı ve Medya",
            "İletişim ve Tasarım",
            "İlköğretim Matematik Öğretmenliği",
            "İmalat Mühendisliği",
            "İngiliz Dili ve Edebiyatı",
            "İngiliz Dili ve Karşılaştırmalı Edebiyat",
            "İngiliz ve Rus Dilleri Edebiyatı",
            "İngilizce Öğretmenliği",
            "İnovasyon, Girişimcilik ve Yönetim",
            "İnsan Kaynakları Yönetimi",
            "İnşaat Mühendisliği",
            "İnşaat Teknolojisi",
            "İslam ve Din Bilimleri",
            "İslami İlimler",
            "İspanyol Dili ve Edebiyatı",
            "İstatistik ve Bilgisayar Bilimleri",
            "İş Sağlığı ve Güvenliği",
            "İşletme",
            "İşletme Bilgi Yönetimi",
            "İşletme Enformatiği",
            "İşletme Mühendisliği",
            "İşletme Yönetimi",
            "Japon Dili ve Edebiyatı",
            "Japonca Öğretmenliği",
            "Jeofizik Mühendisliği",
            "Jeoloji Mühendisliği",
            "Kamu Yönetimi",
            "Kanatlı Hayvan Yetiştiriciliği (MYO)",
            "Karşılaştırmalı Edebiyat",
            "Kimya",
            "Kimya - Biyoloji Mühendisliği",
            "Kimya Mühendisliği",
            "Kimya Öğretmenliği",
            "Kimya ve Süreç Mühendisliği",
            "Konaklama İşletmeciliği",
            "Kore Dili ve Edebiyatı",
            "Kürt Dili Ve Edabiyatı",
            "Laborant ve Veteriner Sağlık (MYO)",
            "Lojistik (MYO)",
            "Lojistik Yönetimi",
            "Maden Mühendisliği",
            "Makine",
            "Makine Mühendisliği",
            "Makine ve İmalat Mühendisliği",
            "Maliye",
            "Malzeme Bilimi ve Mühendisliği",
            "Malzeme Bilimi ve Nanoteknoloji Mühendisliği",
            "Mantarcılık (MYO)",
            "Matematik",
            "Matematik Mühendisliği",
            "Matematik Öğretmenliği",
            "Matematik ve Bilgisayar Bilimleri",
            "Medya ve İletişim",
            "Mekatronik (MYO)",
            "Mekatronik Mühendisliği",
            "Mekatronik Sistemler Mühendisliği",
            "Metalurji ve Malzeme Mühendisliği",
            "Meteoroloji Mühendisliği",
            "Mimari Restorasyon",
            "Mimarlık",
            "Mobilya ve Dekorasyon (MYO)",
            "Moda Tasarımı",
            "Moda ve Tekstil Tasarımı",
            "Modern Dans",
            "Moleküler Biyoloji ve Genetik",
            "Muhasebe",
            "Muhasebe Bilgi Sistemleri",
            "Muhasebe ve Denetim",
            "Muhasebe ve Vergi Uygulamaları",
            "Mütercim Tercümanlık",
            "Müzecilik (MYO)",
            "Müzik",
            "Müzik Bilimleri",
            "Müzikoloji",
            "Nanobilim ve Nanoteknoloji",
            "Nanoteknoloji Mühendisliği",
            "Nükleer Enerji Mühendisliği",
            "Odyoloji",
            "Okul Öncesi Öğretmenlik",
            "Optik ve Akustik Mühendisliği",
            "Organik Tarım (MYO)",
            "Orman Endüstri Mühendisliği",
            "Orman Mühendisliği",
            "Ormancılık (MYO)",
            "Otomotiv Mühendisliği",
            "Oyunculuk",
            "Pazarlama",
            "Perfüzyon",
            "Petrol ve Doğalgaz Mühendisliği",
            "Peyzaj Mimarisi ve Kentsel Tasarım",
            "Peyzaj Mimarlığı",
            "Pilot Eğitimi",
            "Pilotaj",
            "Plastik Sanatlar",
            "Polimer Mühendisliği",
            "Psikoloji",
            "Psikolojik Danışmanlık ve Rehberlik Öğretmenliği"});
            this.txtBolum.Location = new System.Drawing.Point(232, 301);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(353, 33);
            this.txtBolum.TabIndex = 4;
            // 
            // FRM_ADDOGRENCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 571);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrenciNO);
            this.Controls.Add(this.txtOgrenciTarih);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.txtOgrenciTel);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADDOGRENCI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDOGRENCI";
            this.Load += new System.EventHandler(this.FRM_ADDOGRENCI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOgrenciTel;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOgrenciSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOgrenciAd;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnOgrenci;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOgrenciNO;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker txtOgrenciTarih;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox txtBolum;
    }
}