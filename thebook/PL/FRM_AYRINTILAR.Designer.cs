
namespace thebook.PL
{
    partial class FRM_AYRINTILAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AYRINTILAR));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.yazdirmaAyarlari = new Bunifu.Framework.UI.BunifuThinButton2();
            this.yazadir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.yazadirmaGozleme = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bitisTarih_satisID = new System.Windows.Forms.Label();
            this.baslaTarih_SatisTarih = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rapor_tarihi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ogrenciAdi = new System.Windows.Forms.Label();
            this.panel_Yazdirma_Sayfa = new System.Windows.Forms.Panel();
            this.ogrenciBolum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kitap_Fiyat = new System.Windows.Forms.Label();
            this.txt_kitap_Fiyat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kullanciId = new System.Windows.Forms.Label();
            this.baslamaTarih = new System.Windows.Forms.Label();
            this.bitisTarih = new System.Windows.Forms.Label();
            this.kullanciAdi = new System.Windows.Forms.Label();
            this.KitapId = new System.Windows.Forms.Label();
            this.KitapAdi = new System.Windows.Forms.Label();
            this.ogrenciId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.panel_Yazdirma_Sayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Controls.Add(this.yazdirmaAyarlari);
            this.panel1.Controls.Add(this.yazadir);
            this.panel1.Controls.Add(this.yazadirmaGozleme);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 60);
            this.panel1.TabIndex = 64;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(782, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(32, 28);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 45;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // yazdirmaAyarlari
            // 
            this.yazdirmaAyarlari.ActiveBorderThickness = 1;
            this.yazdirmaAyarlari.ActiveCornerRadius = 20;
            this.yazdirmaAyarlari.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.yazdirmaAyarlari.ActiveForecolor = System.Drawing.Color.White;
            this.yazdirmaAyarlari.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.yazdirmaAyarlari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yazdirmaAyarlari.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.yazdirmaAyarlari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yazdirmaAyarlari.BackgroundImage")));
            this.yazdirmaAyarlari.ButtonText = "Yazdirma Ayarları";
            this.yazdirmaAyarlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yazdirmaAyarlari.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazdirmaAyarlari.ForeColor = System.Drawing.Color.SeaGreen;
            this.yazdirmaAyarlari.IdleBorderThickness = 1;
            this.yazdirmaAyarlari.IdleCornerRadius = 20;
            this.yazdirmaAyarlari.IdleFillColor = System.Drawing.Color.White;
            this.yazdirmaAyarlari.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.yazdirmaAyarlari.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.yazdirmaAyarlari.Location = new System.Drawing.Point(555, 14);
            this.yazdirmaAyarlari.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.yazdirmaAyarlari.Name = "yazdirmaAyarlari";
            this.yazdirmaAyarlari.Size = new System.Drawing.Size(124, 37);
            this.yazdirmaAyarlari.TabIndex = 67;
            this.yazdirmaAyarlari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yazdirmaAyarlari.Click += new System.EventHandler(this.yazdirmaAyarlari_Click);
            // 
            // yazadir
            // 
            this.yazadir.ActiveBorderThickness = 1;
            this.yazadir.ActiveCornerRadius = 20;
            this.yazadir.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.yazadir.ActiveForecolor = System.Drawing.Color.White;
            this.yazadir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.yazadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yazadir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.yazadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yazadir.BackgroundImage")));
            this.yazadir.ButtonText = "Yazdır";
            this.yazadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yazadir.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazadir.ForeColor = System.Drawing.Color.SeaGreen;
            this.yazadir.IdleBorderThickness = 1;
            this.yazadir.IdleCornerRadius = 20;
            this.yazadir.IdleFillColor = System.Drawing.Color.White;
            this.yazadir.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.yazadir.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.yazadir.Location = new System.Drawing.Point(184, 14);
            this.yazadir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.yazadir.Name = "yazadir";
            this.yazadir.Size = new System.Drawing.Size(124, 37);
            this.yazadir.TabIndex = 69;
            this.yazadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yazadir.Click += new System.EventHandler(this.yazadir_Click);
            // 
            // yazadirmaGozleme
            // 
            this.yazadirmaGozleme.ActiveBorderThickness = 1;
            this.yazadirmaGozleme.ActiveCornerRadius = 20;
            this.yazadirmaGozleme.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.yazadirmaGozleme.ActiveForecolor = System.Drawing.Color.White;
            this.yazadirmaGozleme.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.yazadirmaGozleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yazadirmaGozleme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.yazadirmaGozleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yazadirmaGozleme.BackgroundImage")));
            this.yazadirmaGozleme.ButtonText = "Önizleme";
            this.yazadirmaGozleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yazadirmaGozleme.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazadirmaGozleme.ForeColor = System.Drawing.Color.SeaGreen;
            this.yazadirmaGozleme.IdleBorderThickness = 1;
            this.yazadirmaGozleme.IdleCornerRadius = 20;
            this.yazadirmaGozleme.IdleFillColor = System.Drawing.Color.White;
            this.yazadirmaGozleme.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.yazadirmaGozleme.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.yazadirmaGozleme.Location = new System.Drawing.Point(366, 14);
            this.yazadirmaGozleme.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.yazadirmaGozleme.Name = "yazadirmaGozleme";
            this.yazadirmaGozleme.Size = new System.Drawing.Size(124, 37);
            this.yazadirmaGozleme.TabIndex = 68;
            this.yazadirmaGozleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yazadirmaGozleme.Click += new System.EventHandler(this.yazadirmaGozleme_Click);
            // 
            // bitisTarih_satisID
            // 
            this.bitisTarih_satisID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bitisTarih_satisID.AutoSize = true;
            this.bitisTarih_satisID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTarih_satisID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bitisTarih_satisID.Location = new System.Drawing.Point(144, 778);
            this.bitisTarih_satisID.Name = "bitisTarih_satisID";
            this.bitisTarih_satisID.Size = new System.Drawing.Size(97, 22);
            this.bitisTarih_satisID.TabIndex = 55;
            this.bitisTarih_satisID.Text = "Bitiş Tarihi";
            // 
            // baslaTarih_SatisTarih
            // 
            this.baslaTarih_SatisTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baslaTarih_SatisTarih.AutoSize = true;
            this.baslaTarih_SatisTarih.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslaTarih_SatisTarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslaTarih_SatisTarih.Location = new System.Drawing.Point(144, 722);
            this.baslaTarih_SatisTarih.Name = "baslaTarih_SatisTarih";
            this.baslaTarih_SatisTarih.Size = new System.Drawing.Size(129, 22);
            this.baslaTarih_SatisTarih.TabIndex = 53;
            this.baslaTarih_SatisTarih.Text = "Başlama Tarihi";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(144, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Öğrenci Adı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(144, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "Kitap Adı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(144, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = "Çalışan Adı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(144, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Çalışan ID";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(144, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 61;
            this.label8.Text = "Kitap ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(144, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Öğrenci No";
            // 
            // baslik
            // 
            this.baslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslik.Location = new System.Drawing.Point(345, 114);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(146, 28);
            this.baslik.TabIndex = 46;
            this.baslik.Text = "Ödünç Rapor";
            this.baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(543, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "Rapor Tarihi :";
            // 
            // rapor_tarihi
            // 
            this.rapor_tarihi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rapor_tarihi.AutoSize = true;
            this.rapor_tarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rapor_tarihi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rapor_tarihi.Location = new System.Drawing.Point(653, 224);
            this.rapor_tarihi.Name = "rapor_tarihi";
            this.rapor_tarihi.Size = new System.Drawing.Size(83, 19);
            this.rapor_tarihi.TabIndex = 64;
            this.rapor_tarihi.Text = "Bitiş Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label10.Location = new System.Drawing.Point(579, 921);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 22);
            this.label10.TabIndex = 65;
            this.label10.Text = "imza";
            // 
            // ogrenciAdi
            // 
            this.ogrenciAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ogrenciAdi.AutoSize = true;
            this.ogrenciAdi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogrenciAdi.Location = new System.Drawing.Point(388, 330);
            this.ogrenciAdi.Name = "ogrenciAdi";
            this.ogrenciAdi.Size = new System.Drawing.Size(104, 22);
            this.ogrenciAdi.TabIndex = 66;
            this.ogrenciAdi.Text = "Öğrenci Adı";
            // 
            // panel_Yazdirma_Sayfa
            // 
            this.panel_Yazdirma_Sayfa.BackColor = System.Drawing.Color.White;
            this.panel_Yazdirma_Sayfa.Controls.Add(this.ogrenciBolum);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label13);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label5);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label4);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.kitap_Fiyat);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.txt_kitap_Fiyat);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label11);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.kullanciId);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.baslamaTarih);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.bitisTarih);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.kullanciAdi);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.KitapId);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.KitapAdi);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.ogrenciId);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.ogrenciAdi);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label10);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.rapor_tarihi);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label9);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.baslik);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label1);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label8);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label2);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label7);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label3);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.label6);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.baslaTarih_SatisTarih);
            this.panel_Yazdirma_Sayfa.Controls.Add(this.bitisTarih_satisID);
            this.panel_Yazdirma_Sayfa.Location = new System.Drawing.Point(22, 66);
            this.panel_Yazdirma_Sayfa.Name = "panel_Yazdirma_Sayfa";
            this.panel_Yazdirma_Sayfa.Size = new System.Drawing.Size(793, 1122);
            this.panel_Yazdirma_Sayfa.TabIndex = 63;
            this.panel_Yazdirma_Sayfa.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Yazdirma_Sayfa_Paint);
            // 
            // ogrenciBolum
            // 
            this.ogrenciBolum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ogrenciBolum.AutoSize = true;
            this.ogrenciBolum.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciBolum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogrenciBolum.Location = new System.Drawing.Point(388, 442);
            this.ogrenciBolum.Name = "ogrenciBolum";
            this.ogrenciBolum.Size = new System.Drawing.Size(141, 22);
            this.ogrenciBolum.TabIndex = 80;
            this.ogrenciBolum.Text = "Öğrenci Bölümü";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(144, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 22);
            this.label13.TabIndex = 79;
            this.label13.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F);
            this.label5.Location = new System.Drawing.Point(284, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 78;
            this.label5.Text = "Kitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F);
            this.label4.Location = new System.Drawing.Point(293, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 77;
            this.label4.Text = "Fırat Üniversitesi";
            // 
            // kitap_Fiyat
            // 
            this.kitap_Fiyat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kitap_Fiyat.AutoSize = true;
            this.kitap_Fiyat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_Fiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kitap_Fiyat.Location = new System.Drawing.Point(388, 834);
            this.kitap_Fiyat.Name = "kitap_Fiyat";
            this.kitap_Fiyat.Size = new System.Drawing.Size(97, 22);
            this.kitap_Fiyat.TabIndex = 76;
            this.kitap_Fiyat.Text = "Bitiş Tarihi";
            this.kitap_Fiyat.Visible = false;
            // 
            // txt_kitap_Fiyat
            // 
            this.txt_kitap_Fiyat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_kitap_Fiyat.AutoSize = true;
            this.txt_kitap_Fiyat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitap_Fiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_kitap_Fiyat.Location = new System.Drawing.Point(144, 834);
            this.txt_kitap_Fiyat.Name = "txt_kitap_Fiyat";
            this.txt_kitap_Fiyat.Size = new System.Drawing.Size(102, 22);
            this.txt_kitap_Fiyat.TabIndex = 75;
            this.txt_kitap_Fiyat.Text = "Kitap Fiyatı";
            this.txt_kitap_Fiyat.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Image = global::thebook.Properties.Resources.Fırat_Üniversitesi_logo__1_;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 135);
            this.label11.TabIndex = 74;
            this.label11.Text = "    ";
            // 
            // kullanciId
            // 
            this.kullanciId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kullanciId.AutoSize = true;
            this.kullanciId.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanciId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullanciId.Location = new System.Drawing.Point(388, 666);
            this.kullanciId.Name = "kullanciId";
            this.kullanciId.Size = new System.Drawing.Size(98, 22);
            this.kullanciId.TabIndex = 73;
            this.kullanciId.Text = "Kullancı ID";
            // 
            // baslamaTarih
            // 
            this.baslamaTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baslamaTarih.AutoSize = true;
            this.baslamaTarih.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslamaTarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baslamaTarih.Location = new System.Drawing.Point(388, 722);
            this.baslamaTarih.Name = "baslamaTarih";
            this.baslamaTarih.Size = new System.Drawing.Size(129, 22);
            this.baslamaTarih.TabIndex = 72;
            this.baslamaTarih.Text = "Başlama Tarihi";
            // 
            // bitisTarih
            // 
            this.bitisTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bitisTarih.AutoSize = true;
            this.bitisTarih.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bitisTarih.Location = new System.Drawing.Point(388, 778);
            this.bitisTarih.Name = "bitisTarih";
            this.bitisTarih.Size = new System.Drawing.Size(97, 22);
            this.bitisTarih.TabIndex = 71;
            this.bitisTarih.Text = "Bitiş Tarihi";
            // 
            // kullanciAdi
            // 
            this.kullanciAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kullanciAdi.AutoSize = true;
            this.kullanciAdi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullanciAdi.Location = new System.Drawing.Point(388, 610);
            this.kullanciAdi.Name = "kullanciAdi";
            this.kullanciAdi.Size = new System.Drawing.Size(107, 22);
            this.kullanciAdi.TabIndex = 70;
            this.kullanciAdi.Text = "Kullancı Adı";
            // 
            // KitapId
            // 
            this.KitapId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KitapId.AutoSize = true;
            this.KitapId.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KitapId.Location = new System.Drawing.Point(388, 554);
            this.KitapId.Name = "KitapId";
            this.KitapId.Size = new System.Drawing.Size(76, 22);
            this.KitapId.TabIndex = 69;
            this.KitapId.Text = "Kitap ID";
            // 
            // KitapAdi
            // 
            this.KitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KitapAdi.AutoSize = true;
            this.KitapAdi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KitapAdi.Location = new System.Drawing.Point(388, 498);
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Size = new System.Drawing.Size(85, 22);
            this.KitapAdi.TabIndex = 68;
            this.KitapAdi.Text = "Kitap Adı";
            // 
            // ogrenciId
            // 
            this.ogrenciId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ogrenciId.AutoSize = true;
            this.ogrenciId.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogrenciId.Location = new System.Drawing.Point(388, 386);
            this.ogrenciId.Name = "ogrenciId";
            this.ogrenciId.Size = new System.Drawing.Size(95, 22);
            this.ogrenciId.TabIndex = 67;
            this.ogrenciId.Text = "Öğrenci ID";
            // 
            // FRM_AYRINTILAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(834, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Yazdirma_Sayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AYRINTILAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AYRINTILAR";
            this.Load += new System.EventHandler(this.FRM_AYRINTILAR_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.panel_Yazdirma_Sayfa.ResumeLayout(false);
            this.panel_Yazdirma_Sayfa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Bunifu.Framework.UI.BunifuThinButton2 yazadir;
        private Bunifu.Framework.UI.BunifuThinButton2 yazadirmaGozleme;
        private Bunifu.Framework.UI.BunifuThinButton2 yazdirmaAyarlari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Yazdirma_Sayfa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label rapor_tarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label kullanciId;
        public System.Windows.Forms.Label baslamaTarih;
        public System.Windows.Forms.Label bitisTarih;
        public System.Windows.Forms.Label kullanciAdi;
        public System.Windows.Forms.Label KitapId;
        public System.Windows.Forms.Label KitapAdi;
        public System.Windows.Forms.Label ogrenciId;
        public System.Windows.Forms.Label ogrenciAdi;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label baslik;
        public System.Windows.Forms.Label bitisTarih_satisID;
        public System.Windows.Forms.Label baslaTarih_SatisTarih;
        public System.Windows.Forms.Label kitap_Fiyat;
        public System.Windows.Forms.Label txt_kitap_Fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label ogrenciBolum;
        private System.Windows.Forms.Label label13;
    }
}