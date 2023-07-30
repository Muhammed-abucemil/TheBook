
namespace thebook.PL
{
    partial class FRM_ADDYAYINEV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDYAYINEV));
            this.Lb_Title = new System.Windows.Forms.Label();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnYayinEv = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtYayinEvAdres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtYayinEvTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYayinEvAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb_Title.Location = new System.Drawing.Point(260, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(280, 75);
            this.Lb_Title.TabIndex = 5;
            this.Lb_Title.Text = "Yayin Evi";
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(741, 9);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 6;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnYayinEv
            // 
            this.btnYayinEv.ActiveBorderThickness = 1;
            this.btnYayinEv.ActiveCornerRadius = 20;
            this.btnYayinEv.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnYayinEv.ActiveForecolor = System.Drawing.Color.White;
            this.btnYayinEv.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnYayinEv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYayinEv.BackColor = System.Drawing.SystemColors.Control;
            this.btnYayinEv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYayinEv.BackgroundImage")));
            this.btnYayinEv.ButtonText = "Ekleme";
            this.btnYayinEv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYayinEv.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEv.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnYayinEv.IdleBorderThickness = 1;
            this.btnYayinEv.IdleCornerRadius = 20;
            this.btnYayinEv.IdleFillColor = System.Drawing.Color.White;
            this.btnYayinEv.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnYayinEv.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnYayinEv.Location = new System.Drawing.Point(161, 496);
            this.btnYayinEv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnYayinEv.Name = "btnYayinEv";
            this.btnYayinEv.Size = new System.Drawing.Size(458, 50);
            this.btnYayinEv.TabIndex = 7;
            this.btnYayinEv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYayinEv.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // txtYayinEvAdres
            // 
            this.txtYayinEvAdres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYayinEvAdres.BackColor = System.Drawing.Color.White;
            this.txtYayinEvAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYayinEvAdres.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYayinEvAdres.HintForeColor = System.Drawing.Color.Empty;
            this.txtYayinEvAdres.HintText = "adres";
            this.txtYayinEvAdres.isPassword = false;
            this.txtYayinEvAdres.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtYayinEvAdres.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYayinEvAdres.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtYayinEvAdres.LineThickness = 4;
            this.txtYayinEvAdres.Location = new System.Drawing.Point(238, 341);
            this.txtYayinEvAdres.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtYayinEvAdres.Name = "txtYayinEvAdres";
            this.txtYayinEvAdres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYayinEvAdres.Size = new System.Drawing.Size(353, 32);
            this.txtYayinEvAdres.TabIndex = 21;
            this.txtYayinEvAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYayinEvTel
            // 
            this.txtYayinEvTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYayinEvTel.BackColor = System.Drawing.Color.White;
            this.txtYayinEvTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYayinEvTel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYayinEvTel.HintForeColor = System.Drawing.Color.Empty;
            this.txtYayinEvTel.HintText = "telefon no";
            this.txtYayinEvTel.isPassword = false;
            this.txtYayinEvTel.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtYayinEvTel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYayinEvTel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtYayinEvTel.LineThickness = 4;
            this.txtYayinEvTel.Location = new System.Drawing.Point(238, 259);
            this.txtYayinEvTel.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtYayinEvTel.Name = "txtYayinEvTel";
            this.txtYayinEvTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYayinEvTel.Size = new System.Drawing.Size(353, 32);
            this.txtYayinEvTel.TabIndex = 20;
            this.txtYayinEvTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(57, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adres";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(57, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYayinEvAd
            // 
            this.txtYayinEvAd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYayinEvAd.BackColor = System.Drawing.Color.White;
            this.txtYayinEvAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYayinEvAd.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYayinEvAd.HintForeColor = System.Drawing.Color.Empty;
            this.txtYayinEvAd.HintText = "adı";
            this.txtYayinEvAd.isPassword = false;
            this.txtYayinEvAd.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtYayinEvAd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYayinEvAd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtYayinEvAd.LineThickness = 4;
            this.txtYayinEvAd.Location = new System.Drawing.Point(238, 177);
            this.txtYayinEvAd.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtYayinEvAd.Name = "txtYayinEvAd";
            this.txtYayinEvAd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYayinEvAd.Size = new System.Drawing.Size(353, 32);
            this.txtYayinEvAd.TabIndex = 17;
            this.txtYayinEvAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_ADDYAYINEV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.txtYayinEvAdres);
            this.Controls.Add(this.txtYayinEvTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYayinEvAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYayinEv);
            this.Controls.Add(this.bunifuImageButton6);
            this.Controls.Add(this.Lb_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ADDYAYINEV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDYAYINEV";
            this.Load += new System.EventHandler(this.FRM_ADDYAYINEV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtYayinEvAdres;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtYayinEvTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtYayinEvAd;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnYayinEv;
    }
}