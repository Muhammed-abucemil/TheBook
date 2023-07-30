
namespace thebook.PL
{
    partial class FRM_SATIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SATIS));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.txtSatisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtOgrenciIDListe = new System.Windows.Forms.ComboBox();
            this.txtKitapIDliste = new System.Windows.Forms.ComboBox();
            this.btnSatis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(80, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tarih";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(80, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Öğrenci ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(80, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kitap ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb_Title.Location = new System.Drawing.Point(231, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(345, 75);
            this.Lb_Title.TabIndex = 31;
            this.Lb_Title.Text = "Satış İşlemi";
            // 
            // txtSatisTarih
            // 
            this.txtSatisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisTarih.Location = new System.Drawing.Point(261, 268);
            this.txtSatisTarih.Name = "txtSatisTarih";
            this.txtSatisTarih.Size = new System.Drawing.Size(353, 29);
            this.txtSatisTarih.TabIndex = 37;
            // 
            // txtOgrenciIDListe
            // 
            this.txtOgrenciIDListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciIDListe.FormattingEnabled = true;
            this.txtOgrenciIDListe.Location = new System.Drawing.Point(261, 213);
            this.txtOgrenciIDListe.Name = "txtOgrenciIDListe";
            this.txtOgrenciIDListe.Size = new System.Drawing.Size(353, 32);
            this.txtOgrenciIDListe.Sorted = true;
            this.txtOgrenciIDListe.TabIndex = 38;
            // 
            // txtKitapIDliste
            // 
            this.txtKitapIDliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapIDliste.FormattingEnabled = true;
            this.txtKitapIDliste.Location = new System.Drawing.Point(261, 157);
            this.txtKitapIDliste.Name = "txtKitapIDliste";
            this.txtKitapIDliste.Size = new System.Drawing.Size(353, 32);
            this.txtKitapIDliste.Sorted = true;
            this.txtKitapIDliste.TabIndex = 39;
            // 
            // btnSatis
            // 
            this.btnSatis.ActiveBorderThickness = 1;
            this.btnSatis.ActiveCornerRadius = 20;
            this.btnSatis.ActiveFillColor = System.Drawing.Color.Olive;
            this.btnSatis.ActiveForecolor = System.Drawing.Color.White;
            this.btnSatis.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSatis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatis.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSatis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSatis.BackgroundImage")));
            this.btnSatis.ButtonText = "Satış Yap";
            this.btnSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatis.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSatis.IdleBorderThickness = 1;
            this.btnSatis.IdleCornerRadius = 20;
            this.btnSatis.IdleFillColor = System.Drawing.Color.LightGray;
            this.btnSatis.IdleForecolor = System.Drawing.Color.DarkGreen;
            this.btnSatis.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnSatis.Location = new System.Drawing.Point(171, 386);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(458, 50);
            this.btnSatis.TabIndex = 40;
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.MediumPurple;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(767, 4);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 46;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FRM_SATIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.txtKitapIDliste);
            this.Controls.Add(this.txtOgrenciIDListe);
            this.Controls.Add(this.txtSatisTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SATIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_SATIS";
            this.Load += new System.EventHandler(this.FRM_SATIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Title;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSatis;
        public System.Windows.Forms.ComboBox txtOgrenciIDListe;
        public System.Windows.Forms.ComboBox txtKitapIDliste;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.DateTimePicker txtSatisTarih;
    }
}