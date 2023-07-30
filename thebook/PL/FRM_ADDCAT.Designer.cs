
namespace thebook.PL
{
    partial class FRM_ADDCAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDCAT));
            this.Lb_Title = new System.Windows.Forms.Label();
            this.txtKategoriName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAyrinti = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb_Title.Location = new System.Drawing.Point(189, 25);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(235, 47);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "Kategori Adı";
            this.Lb_Title.Click += new System.EventHandler(this.Lb_Title_Click);
            // 
            // txtKategoriName
            // 
            this.txtKategoriName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKategoriName.BackColor = System.Drawing.Color.White;
            this.txtKategoriName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKategoriName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKategoriName.HintForeColor = System.Drawing.Color.Empty;
            this.txtKategoriName.HintText = "kategoi adı";
            this.txtKategoriName.isPassword = false;
            this.txtKategoriName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKategoriName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKategoriName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKategoriName.LineThickness = 4;
            this.txtKategoriName.Location = new System.Drawing.Point(123, 80);
            this.txtKategoriName.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtKategoriName.Name = "txtKategoriName";
            this.txtKategoriName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKategoriName.Size = new System.Drawing.Size(364, 47);
            this.txtKategoriName.TabIndex = 4;
            this.txtKategoriName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(120, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori Ayrıntıları";
            // 
            // txtKategoriAyrinti
            // 
            this.txtKategoriAyrinti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKategoriAyrinti.BackColor = System.Drawing.Color.White;
            this.txtKategoriAyrinti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKategoriAyrinti.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAyrinti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKategoriAyrinti.HintForeColor = System.Drawing.Color.Empty;
            this.txtKategoriAyrinti.HintText = "kategoi ayrıntıları";
            this.txtKategoriAyrinti.isPassword = false;
            this.txtKategoriAyrinti.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtKategoriAyrinti.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKategoriAyrinti.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtKategoriAyrinti.LineThickness = 5;
            this.txtKategoriAyrinti.Location = new System.Drawing.Point(123, 240);
            this.txtKategoriAyrinti.Margin = new System.Windows.Forms.Padding(6);
            this.txtKategoriAyrinti.Name = "txtKategoriAyrinti";
            this.txtKategoriAyrinti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKategoriAyrinti.Size = new System.Drawing.Size(364, 109);
            this.txtKategoriAyrinti.TabIndex = 6;
            this.txtKategoriAyrinti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "Ekle";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadd.ForeColor = System.Drawing.Color.Navy;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.White;
            this.btnadd.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(89, 416);
            this.btnadd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(458, 50);
            this.btnadd.TabIndex = 7;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.SpringGreen;
            this.bunifuImageButton6.Image = global::thebook.Properties.Resources.close;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(601, 5);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(27, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 2;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // FRM_ADDCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(636, 481);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtKategoriAyrinti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategoriName);
            this.Controls.Add(this.Lb_Title);
            this.Controls.Add(this.bunifuImageButton6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_ADDCAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDCAT";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtKategoriName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtKategoriAyrinti;
    }
}