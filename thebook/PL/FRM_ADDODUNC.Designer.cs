
namespace thebook.PL
{
    partial class FRM_ADDODUNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDODUNC));
            this.Lb_Title = new System.Windows.Forms.Label();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtOduncKitapIDliste = new System.Windows.Forms.ComboBox();
            this.txtOduncOgrenciIDListe = new System.Windows.Forms.ComboBox();
            this.txtOdunBaslaTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdunBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdunc = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb_Title.Location = new System.Drawing.Point(242, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(391, 75);
            this.Lb_Title.TabIndex = 32;
            this.Lb_Title.Text = "Ödünç İşlemi";
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Beige;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(841, 5);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 47;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtOduncKitapIDliste
            // 
            this.txtOduncKitapIDliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOduncKitapIDliste.FormattingEnabled = true;
            this.txtOduncKitapIDliste.Location = new System.Drawing.Point(280, 148);
            this.txtOduncKitapIDliste.Name = "txtOduncKitapIDliste";
            this.txtOduncKitapIDliste.Size = new System.Drawing.Size(353, 32);
            this.txtOduncKitapIDliste.Sorted = true;
            this.txtOduncKitapIDliste.TabIndex = 53;
            // 
            // txtOduncOgrenciIDListe
            // 
            this.txtOduncOgrenciIDListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOduncOgrenciIDListe.FormattingEnabled = true;
            this.txtOduncOgrenciIDListe.Location = new System.Drawing.Point(280, 212);
            this.txtOduncOgrenciIDListe.Name = "txtOduncOgrenciIDListe";
            this.txtOduncOgrenciIDListe.Size = new System.Drawing.Size(353, 32);
            this.txtOduncOgrenciIDListe.Sorted = true;
            this.txtOduncOgrenciIDListe.TabIndex = 52;
            // 
            // txtOdunBaslaTarih
            // 
            this.txtOdunBaslaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdunBaslaTarih.Location = new System.Drawing.Point(280, 276);
            this.txtOdunBaslaTarih.Name = "txtOdunBaslaTarih";
            this.txtOdunBaslaTarih.Size = new System.Drawing.Size(353, 29);
            this.txtOdunBaslaTarih.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(95, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Başlama Tarih";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(95, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Öğrenci ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Kitap ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOdunBitisTarih
            // 
            this.txtOdunBitisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdunBitisTarih.Location = new System.Drawing.Point(280, 337);
            this.txtOdunBitisTarih.Name = "txtOdunBitisTarih";
            this.txtOdunBitisTarih.Size = new System.Drawing.Size(353, 29);
            this.txtOdunBitisTarih.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(95, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Bitiş Tarih";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdunc
            // 
            this.btnOdunc.ActiveBorderThickness = 1;
            this.btnOdunc.ActiveCornerRadius = 20;
            this.btnOdunc.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOdunc.ActiveForecolor = System.Drawing.Color.White;
            this.btnOdunc.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOdunc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOdunc.BackColor = System.Drawing.SystemColors.Control;
            this.btnOdunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdunc.BackgroundImage")));
            this.btnOdunc.ButtonText = "Ödünç Yap";
            this.btnOdunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdunc.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdunc.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOdunc.IdleBorderThickness = 1;
            this.btnOdunc.IdleCornerRadius = 20;
            this.btnOdunc.IdleFillColor = System.Drawing.Color.White;
            this.btnOdunc.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOdunc.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOdunc.Location = new System.Drawing.Point(208, 414);
            this.btnOdunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(458, 50);
            this.btnOdunc.TabIndex = 56;
            this.btnOdunc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // FRM_ADDODUNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 478);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.txtOdunBitisTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOduncKitapIDliste);
            this.Controls.Add(this.txtOduncOgrenciIDListe);
            this.Controls.Add(this.txtOdunBaslaTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADDODUNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDODUNC";
            this.Load += new System.EventHandler(this.FRM_ADDODUNC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.DateTimePicker txtOdunBitisTarih;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox txtOduncKitapIDliste;
        public System.Windows.Forms.ComboBox txtOduncOgrenciIDListe;
        public System.Windows.Forms.DateTimePicker txtOdunBaslaTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnOdunc;
    }
}