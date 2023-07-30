
namespace thebook.PL
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.Lb_Title = new System.Windows.Forms.Label();
            this.txtKullancıSifre = new System.Windows.Forms.TextBox();
            this.txtKullanciAd = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pass_show = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKitap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.Color.Firebrick;
            this.Lb_Title.Location = new System.Drawing.Point(185, 174);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(88, 41);
            this.Lb_Title.TabIndex = 46;
            this.Lb_Title.Text = "Giriş";
            // 
            // txtKullancıSifre
            // 
            this.txtKullancıSifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKullancıSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullancıSifre.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtKullancıSifre.Location = new System.Drawing.Point(122, 304);
            this.txtKullancıSifre.Name = "txtKullancıSifre";
            this.txtKullancıSifre.Size = new System.Drawing.Size(219, 25);
            this.txtKullancıSifre.TabIndex = 2;
            this.txtKullancıSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKullanciAd
            // 
            this.txtKullanciAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKullanciAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanciAd.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtKullanciAd.Location = new System.Drawing.Point(122, 252);
            this.txtKullanciAd.Name = "txtKullanciAd";
            this.txtKullanciAd.Size = new System.Drawing.Size(219, 25);
            this.txtKullanciAd.TabIndex = 1;
            this.txtKullanciAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.txtKullanciAd;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.txtKullancıSifre;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(202, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Çıkış";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pass_show
            // 
            this.pass_show.Image = global::thebook.Properties.Resources.password_show;
            this.pass_show.Location = new System.Drawing.Point(344, 303);
            this.pass_show.Name = "pass_show";
            this.pass_show.Size = new System.Drawing.Size(23, 23);
            this.pass_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pass_show.TabIndex = 60;
            this.pass_show.TabStop = false;
            this.pass_show.Click += new System.EventHandler(this.pass_show_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::thebook.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(95, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::thebook.Properties.Resources.firat_logo;
            this.pictureBox1.Location = new System.Drawing.Point(142, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnKitap
            // 
            this.btnKitap.ActiveBorderThickness = 1;
            this.btnKitap.ActiveCornerRadius = 20;
            this.btnKitap.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.btnKitap.ActiveForecolor = System.Drawing.Color.White;
            this.btnKitap.ActiveLineColor = System.Drawing.Color.Black;
            this.btnKitap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKitap.BackColor = System.Drawing.Color.White;
            this.btnKitap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKitap.BackgroundImage")));
            this.btnKitap.ButtonText = "Giriş";
            this.btnKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitap.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKitap.IdleBorderThickness = 1;
            this.btnKitap.IdleCornerRadius = 20;
            this.btnKitap.IdleFillColor = System.Drawing.Color.IndianRed;
            this.btnKitap.IdleForecolor = System.Drawing.Color.Black;
            this.btnKitap.IdleLineColor = System.Drawing.Color.Black;
            this.btnKitap.Location = new System.Drawing.Point(136, 364);
            this.btnKitap.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(193, 42);
            this.btnKitap.TabIndex = 3;
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(176, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Öğrenci Giriş";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pass_show);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKullanciAd);
            this.Controls.Add(this.txtKullancıSifre);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.Lb_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lb_Title;
        public Bunifu.Framework.UI.BunifuThinButton2 btnKitap;
        private System.Windows.Forms.TextBox txtKullancıSifre;
        private System.Windows.Forms.TextBox txtKullanciAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pass_show;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Label label1;
    }
}