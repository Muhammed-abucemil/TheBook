
namespace thebook.PL
{
    partial class FRM_ADDKITAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDKITAP));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnKitap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapAdet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKitapFiyat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapKategori = new System.Windows.Forms.ComboBox();
            this.txtKitapYazar = new System.Windows.Forms.ComboBox();
            this.txtKitapYayinEv = new System.Windows.Forms.ComboBox();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtKitapYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnKitap
            // 
            this.btnKitap.ActiveBorderThickness = 1;
            this.btnKitap.ActiveCornerRadius = 20;
            this.btnKitap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKitap.ActiveForecolor = System.Drawing.Color.White;
            this.btnKitap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKitap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKitap.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKitap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKitap.BackgroundImage")));
            this.btnKitap.ButtonText = "Ekleme";
            this.btnKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitap.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKitap.IdleBorderThickness = 1;
            this.btnKitap.IdleCornerRadius = 20;
            this.btnKitap.IdleFillColor = System.Drawing.Color.White;
            this.btnKitap.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKitap.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKitap.Location = new System.Drawing.Point(185, 538);
            this.btnKitap.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(458, 50);
            this.btnKitap.TabIndex = 35;
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKitap.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(59, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 32);
            this.label7.TabIndex = 33;
            this.label7.Text = "Kategori";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKitapAdet
            // 
            this.txtKitapAdet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKitapAdet.BackColor = System.Drawing.Color.White;
            this.txtKitapAdet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKitapAdet.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKitapAdet.HintForeColor = System.Drawing.Color.Empty;
            this.txtKitapAdet.HintText = "adet";
            this.txtKitapAdet.isPassword = false;
            this.txtKitapAdet.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKitapAdet.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKitapAdet.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKitapAdet.LineThickness = 4;
            this.txtKitapAdet.Location = new System.Drawing.Point(240, 232);
            this.txtKitapAdet.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtKitapAdet.Name = "txtKitapAdet";
            this.txtKitapAdet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKitapAdet.Size = new System.Drawing.Size(353, 32);
            this.txtKitapAdet.TabIndex = 30;
            this.txtKitapAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKitapFiyat
            // 
            this.txtKitapFiyat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKitapFiyat.BackColor = System.Drawing.Color.White;
            this.txtKitapFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKitapFiyat.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKitapFiyat.HintForeColor = System.Drawing.Color.Empty;
            this.txtKitapFiyat.HintText = "fiyat";
            this.txtKitapFiyat.isPassword = false;
            this.txtKitapFiyat.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKitapFiyat.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKitapFiyat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKitapFiyat.LineThickness = 4;
            this.txtKitapFiyat.Location = new System.Drawing.Point(240, 175);
            this.txtKitapFiyat.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtKitapFiyat.Name = "txtKitapFiyat";
            this.txtKitapFiyat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKitapFiyat.Size = new System.Drawing.Size(353, 32);
            this.txtKitapFiyat.TabIndex = 29;
            this.txtKitapFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(59, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "YayinTarihi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(59, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Adet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(59, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fiyat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKitapAd.BackColor = System.Drawing.Color.White;
            this.txtKitapAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKitapAd.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKitapAd.HintForeColor = System.Drawing.Color.Empty;
            this.txtKitapAd.HintText = "adı";
            this.txtKitapAd.isPassword = false;
            this.txtKitapAd.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKitapAd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKitapAd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKitapAd.LineThickness = 4;
            this.txtKitapAd.Location = new System.Drawing.Point(240, 118);
            this.txtKitapAd.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKitapAd.Size = new System.Drawing.Size(353, 32);
            this.txtKitapAd.TabIndex = 23;
            this.txtKitapAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb_Title.Location = new System.Drawing.Point(304, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(179, 75);
            this.Lb_Title.TabIndex = 21;
            this.Lb_Title.Text = "Kitap";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(59, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "Yazar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(59, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Yayın Evi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKitapKategori
            // 
            this.txtKitapKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKitapKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapKategori.FormattingEnabled = true;
            this.txtKitapKategori.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtKitapKategori.Location = new System.Drawing.Point(234, 349);
            this.txtKitapKategori.Name = "txtKitapKategori";
            this.txtKitapKategori.Size = new System.Drawing.Size(353, 33);
            this.txtKitapKategori.Sorted = true;
            this.txtKitapKategori.TabIndex = 41;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazar.FormattingEnabled = true;
            this.txtKitapYazar.Location = new System.Drawing.Point(234, 406);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(353, 33);
            this.txtKitapYazar.Sorted = true;
            this.txtKitapYazar.TabIndex = 42;
            // 
            // txtKitapYayinEv
            // 
            this.txtKitapYayinEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYayinEv.FormattingEnabled = true;
            this.txtKitapYayinEv.Location = new System.Drawing.Point(234, 463);
            this.txtKitapYayinEv.Name = "txtKitapYayinEv";
            this.txtKitapYayinEv.Size = new System.Drawing.Size(353, 33);
            this.txtKitapYayinEv.Sorted = true;
            this.txtKitapYayinEv.TabIndex = 43;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.CadetBlue;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(796, 4);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 44;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // txtKitapYayinTarihi
            // 
            this.txtKitapYayinTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYayinTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYayinTarihi.Location = new System.Drawing.Point(240, 289);
            this.txtKitapYayinTarihi.Name = "txtKitapYayinTarihi";
            this.txtKitapYayinTarihi.Size = new System.Drawing.Size(347, 29);
            this.txtKitapYayinTarihi.TabIndex = 45;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(611, 361);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 20);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kategori Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FRM_ADDKITAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(829, 597);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtKitapYayinTarihi);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.txtKitapYayinEv);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.txtKitapKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKitapAdet);
            this.Controls.Add(this.txtKitapFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADDKITAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDKITAP";
            this.Load += new System.EventHandler(this.FRM_ADDKITAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.ComboBox txtKitapYayinEv;
        public System.Windows.Forms.ComboBox txtKitapYazar;
        public System.Windows.Forms.ComboBox txtKitapKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuThinButton2 btnKitap;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtKitapAdet;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtKitapFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Title;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        public System.Windows.Forms.DateTimePicker txtKitapYayinTarihi;
        public System.Windows.Forms.LinkLabel linkLabel1;
    }
}