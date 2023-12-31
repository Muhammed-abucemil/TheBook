﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thebook.PL
{
    public partial class FRM_MAIN : Form
    {
        String State;
        int ID;
        public int Aktif_Kullanci_ID;
        public String Aktif_Kullanci_Yetkisi;
        // kategori içın değişkenler
        BL.CLC_CAT BLCAT = new BL.CLC_CAT();
        BL.CLC_USER BLUSER = new BL.CLC_USER();
        BL.CLC_OGRENCI BLOGRENCI = new BL.CLC_OGRENCI();
        BL.CLC_YAZAR BLYAZAR = new BL.CLC_YAZAR();
        BL.CLC_YAYINEV BLYAYINEV = new BL.CLC_YAYINEV();
        BL.CLC_KITAP BLKITAP = new BL.CLC_KITAP();
        BL.CLC_SATIS BLSATIS = new BL.CLC_SATIS();
        BL.CLC_ODUNC BLODUNC = new BL.CLC_ODUNC();


       
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(00, 00, 28);
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "Ana Sayfa";

            txtIDshow.Text = Convert.ToString(Aktif_Kullanci_ID);
            txtYetkishow.Text = Convert.ToString(Aktif_Kullanci_Yetkisi);

            /// çalışan ve yönetici yetkileri
            if (txtYetkishow.Text.Trim() == "Çalışan")
            {
                button13.Enabled = false;
                button7.Enabled = false;
                button10.Enabled = false;
            }
            else
            {
                button13.Enabled = true;
                button7.Enabled = true;
            }
        }

       
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

   

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            /// çıkıiş yapmak
            PL.FRM_LOGIN SHOWLOGIN = new FRM_LOGIN();
            SHOWLOGIN.Show();
            this.Hide();
           
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button1.BackColor = Color.FromArgb(00, 00, 28);
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "Ana Sayfa";
            DataTable dt = new DataTable();
            dt = BLCAT.load();
            txtKategoriSayisi.Text = Convert.ToString(dt.Rows.Count);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if(P_MB.Size.Width == 175)
            {
                P_MB.Width = 50;
                img.Visible = false;
                txtIDshow.Visible = false;
                txtYetkishow.Visible = false;
            }
            else
            {
                P_MB.Width = 175;
                img.Visible = true;
                txtIDshow.Visible = true;
                txtYetkishow.Visible = true;
            }
        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
        
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button18.BackColor = Color.FromArgb(00, 00, 28);
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                btnSatisIslemi.Visible = true;
                bunifuThinButton21.Visible = true;
                bunifuThinButton24.Visible = true;
                bunifuThinButton23.Visible = true;
                bunifuThinButton22.Visible = true;
            }
            

            bunifuThinButton24.ButtonText = "Ödünç";
            btnSatisIslemi.ButtonText = "Satış Yap";
            State = "BOOK";
            Lb_Title.Text = "Kitaplar";
            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLKITAP.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Ad";
                dataGridView1.Columns[2].HeaderText = "Yayın Tarihi";
                dataGridView1.Columns[3].HeaderText = "Fiyat";
                dataGridView1.Columns[4].HeaderText = "Adet";
                dataGridView1.Columns[5].HeaderText = "Yayın Ev";
                dataGridView1.Columns[6].HeaderText = "Kategori";
                dataGridView1.Columns[7].HeaderText = "yazar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Kitap_satir_Renklendirme(); ///------kitaplar kontrolu - renklendirme--


        }
        ///------kitaplar kontrolu - renklendirme--
        public void Kitap_satir_Renklendirme()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int adet = Convert.ToInt32(row.Cells[4].Value);
                int fiyat = Convert.ToInt32(row.Cells[3].Value);
                if (adet == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                if (fiyat == 0 && adet!=0)
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button14.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
           
            bunifuThinButton24.Visible = true;
            btnSatisIslemi.Visible = true;
            bunifuThinButton22.Visible = true;
            
                
            bunifuThinButton24.ButtonText = "Ayrıntılar";
            btnSatisIslemi.ButtonText = "Iade Etmek";
            State = "ODUNC";
            Lb_Title.Text = "Ödünç";

            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLODUNC.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Öğrenci NO";
                dataGridView1.Columns[1].HeaderText = "Kullancı ID";
                dataGridView1.Columns[2].HeaderText = "Kitap ID";
                dataGridView1.Columns[3].HeaderText = "Başlama Tarihi";
                dataGridView1.Columns[4].HeaderText = "Bitiş Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Odunc_satir_Renklendirme(); ///------Ödünç işlemleri kontrolu - renklendirme--

        }
        ///------Ödünç işlemleri kontrolu - renklendirme--
        public void Odunc_satir_Renklendirme()
        {
            ///--------
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime bitisTarih = Convert.ToDateTime(Convert.ToString(row.Cells[4].Value).Trim());
                if (DateTime.Now > bitisTarih)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

            private void button15_Click(object sender, EventArgs e)
            {
            setcolor(); // color change
            button15.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = true;
            btnSatisIslemi.Visible = true;
            bunifuThinButton22.Visible = true;
            bunifuThinButton24.ButtonText = "Ayrıntılar";
            btnSatisIslemi.ButtonText = "Iade Etmek";
            State = "SATIS";
            Lb_Title.Text = "Satışlar";
            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLSATIS.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Satış ID";
                dataGridView1.Columns[1].HeaderText = "Kullancı ID";
                dataGridView1.Columns[2].HeaderText = "Öğrenci NO";
                dataGridView1.Columns[3].HeaderText = "Kitap ID";
                dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button16.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                bunifuThinButton21.Visible = true;
                bunifuThinButton23.Visible = true;
                bunifuThinButton22.Visible = true;
            }
                
            State = "CAT";
            Lb_Title.Text = "Kategori";
            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLCAT.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Adı";
                dataGridView1.Columns[2].HeaderText = "Ayrıntıları";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button17.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton21.Visible = true;
            bunifuThinButton23.Visible = true;
            bunifuThinButton22.Visible = true;
            State = "STUDENT";
            Lb_Title.Text = "Öğrenciler";
            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLOGRENCI.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "NO";
                dataGridView1.Columns[1].HeaderText = "Ad";
                dataGridView1.Columns[2].HeaderText = "Soyad";
                dataGridView1.Columns[3].HeaderText = "Bölüm";
                dataGridView1.Columns[4].HeaderText = "Tel";
                dataGridView1.Columns[5].HeaderText = "Kayit Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);///------Öğrenciler kontrolu - renklendirme--
            }
            Ogrenci_Satir_Renklendirme();
        }
        /// 
        ///------Öğrenciler kontrolu - renklendirme--
        public void Ogrenci_Satir_Renklendirme()
        {
            BL.CLC_ODUNC BLODUNC = new BL.CLC_ODUNC();

            
                ///--------
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int Alinan_Kitap_Sayisi = BLODUNC.Odubc_Kitap_sayisi(Convert.ToInt32(Convert.ToInt32(row.Cells[0].Value))).Rows.Count;
                    if (Alinan_Kitap_Sayisi == 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            
        }
        private void button13_Click_2(object sender, EventArgs e)
        {
            setcolor(); // color change
            button13.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton21.Visible = true;
            bunifuThinButton23.Visible = true;
            bunifuThinButton22.Visible = true;
            State = "USER";
            Lb_Title.Text = "Kullancılar";
            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLUSER.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Ad";
                dataGridView1.Columns[2].HeaderText = "Soyad";
                dataGridView1.Columns[3].HeaderText = "Email";
                dataGridView1.Columns[4].HeaderText = "Tel";
                dataGridView1.Columns[5].HeaderText = "Adres";
                dataGridView1.Columns[6].HeaderText = "Yetki";
                dataGridView1.Columns[7].HeaderText = "Şifre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDCAT ADDFCAT = new FRM_ADDCAT();
            ADDFCAT.btnadd.ButtonText = "Ekleme";
            ADDFCAT.ID = 0;
            bunifuTransition1.ShowSync(ADDFCAT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDKITAP ADDFKITAP = new FRM_ADDKITAP();
            ADDFKITAP.btnKitap.ButtonText = "Ekleme";
            ADDFKITAP.ID = 0;
            bunifuTransition1.ShowSync(ADDFKITAP);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDYAZAR ADDYAZAR = new FRM_ADDYAZAR();
            ADDYAZAR.btnYazar.ButtonText = "Ekleme";
            ADDYAZAR.ID = 0;
            bunifuTransition1.ShowSync(ADDYAZAR);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDYAYINEV ADDYAYINEV = new FRM_ADDYAYINEV();
            ADDYAYINEV.btnYayinEv.ButtonText = "Ekleme";
            ADDYAYINEV.ID = 0;
            bunifuTransition1.ShowSync(ADDYAYINEV);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDOGRENCI ADDFOGRENCI = new FRM_ADDOGRENCI();
            ADDFOGRENCI.btnOgrenci.ButtonText = "Ekleme";
            ADDFOGRENCI.ID = 0;
            bunifuTransition1.ShowSync(ADDFOGRENCI);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            /// ADD KATEGORI
            if (State == "CAT")
            {
                PL.FRM_ADDCAT ADDFCAT = new FRM_ADDCAT();
                ADDFCAT.btnadd.ButtonText = "Ekleme";
                ADDFCAT.ID = 0;
                bunifuTransition1.ShowSync(ADDFCAT);
            }


            // add user
            if (State == "USER")
            {
                PL.FRM_ADDUSER ADDFUSER = new FRM_ADDUSER();
                ADDFUSER.bunifuThinButton23.ButtonText = "Ekleme";
                ADDFUSER.ID = 0;
                bunifuTransition1.ShowSync(ADDFUSER);
            }

            // add ogrenci
            if (State == "STUDENT")
            {
                PL.FRM_ADDOGRENCI ADDFOGRENCI = new FRM_ADDOGRENCI();
                ADDFOGRENCI.btnOgrenci.ButtonText = "Ekleme";
                ADDFOGRENCI.ID = 0;
                bunifuTransition1.ShowSync(ADDFOGRENCI);
            }
            /// ADD YAZAR
            if (State == "YAZAR")
            {
                PL.FRM_ADDYAZAR ADDYAZAR = new FRM_ADDYAZAR();
                ADDYAZAR.btnYazar.ButtonText = "Ekleme";
                ADDYAZAR.ID = 0;
                bunifuTransition1.ShowSync(ADDYAZAR);
            }
            /// ADD YAYIN EV
            if (State == "YAYEV")
            {
                PL.FRM_ADDYAYINEV ADDFYAYINEV = new FRM_ADDYAYINEV();
                ADDFYAYINEV.btnYayinEv.ButtonText = "Ekleme";
                ADDFYAYINEV.ID = 0;
                bunifuTransition1.ShowSync(ADDFYAYINEV);
            }
            /// ADD Kitap
            if (State == "BOOK")
            {
                PL.FRM_ADDKITAP ADDFKITAP = new FRM_ADDKITAP();
                ADDFKITAP.btnKitap.ButtonText = "Ekleme";
                ADDFKITAP.ID = 0;
                bunifuTransition1.ShowSync(ADDFKITAP);
            }
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
           
            /// Ana sayfada Bulunan bilgilerin gostermesi
            DataTable dt2 = new DataTable();
            dt2 = BLCAT.load();
            txtKategoriSayisi.Text = Convert.ToString(dt2.Rows.Count);
            dt2 = BLOGRENCI.load();
            OgrenciSayisi.Text = Convert.ToString(dt2.Rows.Count);
            dt2 = BLUSER.load();
            txtKullanciSayisi.Text= Convert.ToString(dt2.Rows.Count);
            dt2 = BLKITAP.load();
            kitapSayisi.Text = Convert.ToString(dt2.Rows.Count);
            dt2 = BLYAYINEV.load();
            YayinEvSayisi.Text= Convert.ToString(dt2.Rows.Count);
            dt2 = BLYAZAR.load();
            YazarSayısı.Text = Convert.ToString(dt2.Rows.Count);
            dt2 = BLSATIS.load();
            txtSatisSayisi.Text = Convert.ToString(dt2.Rows.Count);
            dt2 = BLODUNC.load();
            txtOduncSayisi.Text = Convert.ToString(dt2.Rows.Count);


          
            if (State == "CAT")
            {
                // Load Data kategori  otomatik olarak yenileme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Adı";
                    dataGridView1.Columns[2].HeaderText = "Ayrıntıları";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (State == "USER")
            {
                // Load Data USER otomatik olarak yenileme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUSER.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Ad";
                    dataGridView1.Columns[2].HeaderText = "Soyad";
                    dataGridView1.Columns[3].HeaderText = "Email";
                    dataGridView1.Columns[4].HeaderText = "Tel";
                    dataGridView1.Columns[5].HeaderText = "Adres";
                    dataGridView1.Columns[6].HeaderText = "Yetki";
                    dataGridView1.Columns[7].HeaderText = "Şifre";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (State == "STUDENT")
            {
                // Load Data OGRENCI otomatik olarak yenileme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLOGRENCI.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Ad";
                    dataGridView1.Columns[2].HeaderText = "Soyad";
                    dataGridView1.Columns[3].HeaderText = "Bölüm";
                    dataGridView1.Columns[4].HeaderText = "Tel";
                    dataGridView1.Columns[5].HeaderText = "Kayit Tarihi";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Ogrenci_Satir_Renklendirme();

            }
            if (State == "YAZAR")
            {
                // Load Data yazar otomatik olarak yenileme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLYAZAR.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Ad";
                    dataGridView1.Columns[2].HeaderText = "Email";
                    dataGridView1.Columns[3].HeaderText = "Tel";
                    dataGridView1.Columns[4].HeaderText = "Adres";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (State == "YAYEV")
            {
                // Load Data yayin ev otomatik olarak yenileme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLYAYINEV.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Ad";
                    dataGridView1.Columns[2].HeaderText = "Adres";
                    dataGridView1.Columns[3].HeaderText = "Tel";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (State == "BOOK")
            {
                // Load Data kITAP otomatik olarak yenileme
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLKITAP.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Ad";
                    dataGridView1.Columns[2].HeaderText = "Yayın Tarihi";
                    dataGridView1.Columns[3].HeaderText = "Fiyat";
                    dataGridView1.Columns[4].HeaderText = "Adet";
                    dataGridView1.Columns[5].HeaderText = "Yayın Ev";
                    dataGridView1.Columns[6].HeaderText = "Kategori";
                    dataGridView1.Columns[7].HeaderText = "yazar";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Kitap_satir_Renklendirme();
            }
            if (State == "SATIS")
            {
                // Load Data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSATIS.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Satış ID";
                    dataGridView1.Columns[1].HeaderText = "Kullancı ID";
                    dataGridView1.Columns[2].HeaderText = "Öğrenci ID";
                    dataGridView1.Columns[3].HeaderText = "Kitap ID";
                    dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (State == "ODUNC")
            {
                // Load Data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLODUNC.load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Öğrenci ID";
                    dataGridView1.Columns[1].HeaderText = "Kullancı ID";
                    dataGridView1.Columns[2].HeaderText = "Kitap ID";
                    dataGridView1.Columns[3].HeaderText = "Başlama Tarihi";
                    dataGridView1.Columns[4].HeaderText = "Bitiş Tarihi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Odunc_satir_Renklendirme();
            }

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için Listede Kayıt bulunmamaktadır");
            }
            else
            {
                /// Update KATEGORI
                if (State == "CAT")
                {
                    PL.FRM_ADDCAT ADDFCAT = new FRM_ADDCAT();
                    ADDFCAT.btnadd.ButtonText = "Düzeltme";
                    ADDFCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDFCAT.txtKategoriName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value).Trim();
                    ADDFCAT.txtKategoriAyrinti.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();

                    bunifuTransition1.ShowSync(ADDFCAT);
                }

                /// Update kullancı
                if (State == "USER")
                {
                    PL.FRM_ADDUSER ADDFUSER = new FRM_ADDUSER();
                    ADDFUSER.bunifuThinButton23.ButtonText = "Düzeltme";
                    ADDFUSER.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDFUSER.txtUserAd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value).Trim();
                    ADDFUSER.txtUserSoyad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDFUSER.txtUserEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();
                    ADDFUSER.txtUserTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value).Trim();
                    ADDFUSER.txtUserAdres.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value).Trim();
                    ADDFUSER.txtUserYetki.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value).Trim();
                    ADDFUSER.txtUserSifre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value).Trim();

                    bunifuTransition1.ShowSync(ADDFUSER);
                }
                /// Update ogrenci
                if (State == "STUDENT")
                {
                    PL.FRM_ADDOGRENCI ADDFOGRENCI = new FRM_ADDOGRENCI();
                    ADDFOGRENCI.txtBolum.DropDownStyle = ComboBoxStyle.DropDown;
                    ADDFOGRENCI.btnOgrenci.ButtonText = "Düzeltme";
                    ADDFOGRENCI.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDFOGRENCI.txtOgrenciNO.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value).Trim();
                    ADDFOGRENCI.txtOgrenciAd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value).Trim();
                    ADDFOGRENCI.txtOgrenciSoyad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDFOGRENCI.txtBolum.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();
                    ADDFOGRENCI.txtOgrenciTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value).Trim();
                    ADDFOGRENCI.txtOgrenciNO.Enabled = false;
                    ADDFOGRENCI.txtOgrenciTarih.Enabled = false;
                    bunifuTransition1.ShowSync(ADDFOGRENCI);
                }

                /// Update YAZAR
                if (State == "YAZAR")
                {
                    PL.FRM_ADDYAZAR ADDFYAZAR = new FRM_ADDYAZAR();
                    ADDFYAZAR.btnYazar.ButtonText = "Düzeltme";
                    ADDFYAZAR.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDFYAZAR.txtYazarAd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value).Trim();
                    ADDFYAZAR.txtYazarEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDFYAZAR.txtYazarTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();
                    ADDFYAZAR.txtYazarAdres.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value).Trim();

                    bunifuTransition1.ShowSync(ADDFYAZAR);
                }

                /// Update YAYIN EV
                if (State == "YAYEV")
                {
                    PL.FRM_ADDYAYINEV ADDFYAYINEV = new FRM_ADDYAYINEV();
                    ADDFYAYINEV.btnYayinEv.ButtonText = "Düzeltme";
                    ADDFYAYINEV.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDFYAYINEV.txtYayinEvAd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value).Trim();
                    ADDFYAYINEV.txtYayinEvAdres.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDFYAYINEV.txtYayinEvTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();


                    bunifuTransition1.ShowSync(ADDFYAYINEV);
                }
                /// Update KITAP
                if (State == "BOOK")
                {
                    PL.FRM_ADDKITAP ADDKITAP = new FRM_ADDKITAP();
                    ADDKITAP.linkLabel1.Enabled = false;
                    ADDKITAP.btnKitap.ButtonText = "Düzeltme";
                    ADDKITAP.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDKITAP.txtKitapAd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value).Trim();
                    ADDKITAP.txtKitapYayinTarihi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDKITAP.txtKitapFiyat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();
                    ADDKITAP.txtKitapAdet.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value).Trim();
                    ADDKITAP.txtKitapYayinEv.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value).Trim();
                    ADDKITAP.txtKitapKategori.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value).Trim();
                    ADDKITAP.txtKitapYazar.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value).Trim();

                    bunifuTransition1.ShowSync(ADDKITAP);
                }
                /// Update SATIŞLAR
                if (State == "SATIS")
                {
                    PL.FRM_SATIS ADDSATIS = new FRM_SATIS();
                    ADDSATIS.Aktif_Kullanci_ID = Aktif_Kullanci_ID;
                    ADDSATIS.txtKitapIDliste.Enabled = false;
                    ADDSATIS.btnSatis.ButtonText = "Düzeltme";
                    ADDSATIS.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ADDSATIS.txtOgrenciIDListe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDSATIS.txtKitapIDliste.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();
                    ADDSATIS.txtSatisTarih.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value).Trim();
                    bunifuTransition1.ShowSync(ADDSATIS);
                }
                /// Update ÖDÜNÇLER
                if (State == "ODUNC")
                {
                    PL.FRM_ADDODUNC ADDODUNC = new FRM_ADDODUNC();
                    ADDODUNC.ID = Aktif_Kullanci_ID;
                    ADDODUNC.Aktif_Kullanci_ID = Aktif_Kullanci_ID;
                    ADDODUNC.txtOduncKitapIDliste.Enabled = false;
                    ADDODUNC.txtOduncOgrenciIDListe.Enabled = false;
                    ADDODUNC.btnOdunc.ButtonText = "Düzeltme";
                    ADDODUNC.txtOduncOgrenciIDListe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value).Trim();
                    ADDODUNC.txtOduncKitapIDliste.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value).Trim();
                    ADDODUNC.txtOdunBaslaTarih.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value).Trim();
                    ADDODUNC.txtOdunBitisTarih.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value).Trim();
                    bunifuTransition1.ShowSync(ADDODUNC);
                }
            }
            

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için Listede Kayıt bulunmamaktadır");
            }
            else
            {
                /// DELETE KATEGORI
                if (State == "CAT")
                {
                    BLCAT.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    if (BLCAT.hata != 0)
                    {
                        PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                        Fdelete.Show();
                    }
                    else
                    {
                        PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                        Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n SİLMEK İSTEDİĞNİZ KATEGORİ GRUBU SİSTEMDE \n KENİSİNE AİT KAYITLI KAİTAPLAR BULUNMAKTADIR !! ";
                        Ferror.Show();
                    }
                }

                /// DELETE Kullanci
                if (State == "USER")
                {
                    PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                    if (this.Aktif_Kullanci_ID != Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value))
                    {
                        BLUSER.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                        if (BLUSER.hata != 0)
                        {
                            PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                            Fdelete.Show();
                        }
                        else
                        {

                            Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n // SİLMEK İSTEDİĞNİZ KULLANCI SİSTEMDE \n KENİSİNE AİT KAYITLI İŞLEMLER VARDIR !! ";
                            Ferror.Show();
                        }
                    }
                    else
                    {
                        Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n       KULLANCI KENDİ KAYIDI SİLEMEZ ";
                        Ferror.Show();
                    }

                }

                /// DELETE OGRENCI
                if (State == "STUDENT")
                {
                    BLOGRENCI.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    if (BLOGRENCI.hata != 0)
                    {
                        PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                        Fdelete.Show();
                    }
                    else
                    {
                        PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                        Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n // SİLMEK İSTEDİĞNİZ ÇĞRENCİ SİSTEMDE\n KENİSİNE AİT KAYITLI İŞLEMLER VARDIR !! ";
                        Ferror.Show();
                    }
                }
                /// DELETE YAZAR
                if (State == "YAZAR")
                {
                    BLYAZAR.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    if (BLYAZAR.hata != 0)
                    {
                        PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                        Fdelete.Show();
                    }
                    else
                    {
                        PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                        Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n SİLMEK İSTEDİĞNİZ YAZARI SİSTEMDE \n KAYITLI BİR KİTABA AİT OLDUĞUNU OLMAKTADIR !! ";
                        Ferror.Show();
                    }

                }
                /// DELETE YAYIN EV
                if (State == "YAYEV")
                {

                    BLYAYINEV.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    if (BLYAYINEV.hata != 0)
                    {
                        PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                        Fdelete.Show();
                    }
                    else
                    {
                        PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                        Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n SİLMEK İSTEDİĞNİZ YAYIN EVI SİSTEMDE \n KAYITLI BİR KİTABA AİT OLDUĞUNU OLMAKTADIR !! ";
                        Ferror.Show();
                    }

                }
                /// DELETE kitap
                if (State == "BOOK")
                {
                    BLKITAP.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    if (BLKITAP.hata != 0)
                    {
                        PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                        Fdelete.Show();
                    }
                    else
                    {
                        PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                        Ferror.Lb_Title.Text = "!!!  UYARI !!!  \n SİLMEK İSTEDİĞNİZ KITAP \n DAHA ÖNCE SATIŞ VEYA ÖDÜNÇ İŞLEMLERİ YAPILDI !! ";
                        Ferror.Show();
                    }

                }
                /// DELETE SATIŞ
                if (State == "SATIS")
                {
                    BLSATIS.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                    Fdelete.Show();
                }
                /// DELETE ÖDÜNÇ
                if (State == "ODUNC")
                {
                    BLODUNC.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
                    PL.FRM_DDELETE Fdelete = new FRM_DDELETE();
                    Fdelete.Show();
                }
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            /// Search KATEGORI
            if (State == "CAT")
            {
                DataTable dt = new DataTable();
                dt=BLCAT.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;
                        
            }

            /// Search Kullanci
            if (State == "USER")
            {
                DataTable dt = new DataTable();
                dt = BLUSER.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }

            /// Search OGRENCI
            if (State == "STUDENT")
            {
                DataTable dt = new DataTable();
                dt = BLOGRENCI.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;
                Ogrenci_Satir_Renklendirme();

            }
            /// Search YAYZAR
            if (State == "YAZAR")
            {
                DataTable dt = new DataTable();
                dt = BLYAZAR.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }

            /// Search YAYIN EVI
            if (State == "YAYEV")
            {
                DataTable dt = new DataTable();
                dt = BLYAYINEV.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }

            /// Search Kitap
            if (State == "BOOK")
            {
                DataTable dt = new DataTable();
                dt = BLKITAP.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;
                this.Kitap_satir_Renklendirme();

            }
            /// Search Satış işlemi
            if (State == "SATIS")
            {
                DataTable dt = new DataTable();
                dt = BLSATIS.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }
            /// Search ödünç işlemi
            if (State == "ODUNC")
            {
                DataTable dt = new DataTable();
                dt = BLODUNC.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;
                this.Odunc_satir_Renklendirme();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button8.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton21.Visible = true;
            bunifuThinButton23.Visible = true;
            bunifuThinButton22.Visible = true;
            State = "YAZAR";
            Lb_Title.Text = "Yazarlar";

            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLYAZAR.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Ad";
                dataGridView1.Columns[2].HeaderText = "Email";
                dataGridView1.Columns[3].HeaderText = "Tel";
                dataGridView1.Columns[4].HeaderText = "Adres";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button9.BackColor = Color.FromArgb(00, 00, 28);
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton21.Visible = true;
            bunifuThinButton23.Visible = true;
            bunifuThinButton22.Visible = true;
            State = "YAYEV";
            Lb_Title.Text = "Yayın Evleri";
            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLYAYINEV.load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Ad";
                dataGridView1.Columns[2].HeaderText = "Adres";
                dataGridView1.Columns[3].HeaderText = "Tel";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            PL.FRM_ADDUSER ADDFUSER = new FRM_ADDUSER();
            ADDFUSER.bunifuThinButton23.ButtonText = "Ekleme";
            ADDFUSER.ID = 0;
            bunifuTransition1.ShowSync(ADDFUSER);
        }

        private void btnSatisIslemi_Click(object sender, EventArgs e)
        {
            PL.FRM_ERRORINSERT ror = new FRM_ERRORINSERT();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için Listede Kayıt bulunmamaktadır");
            }
            else
            {
                if (State == "BOOK")
                {
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) == 0)
                    {

                        ror.Lb_Title.Text = "!!!UYARI !!! \n BU KITAP ÜZERİNDE SATIN İŞLEMİ YAPILMAZ \n , SADECE ÖDÜNÇ İŞLEMİ YAPILABİLİR ";
                        ror.Show();
                    }
                    else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value) == 0)
                    {
                        ror.Lb_Title.Text = "!!!UYARI !!! \n İSTEDİĞİNİZ KİTAP ŞUANDA \n KÜTÜPHANEDE YETERLİ SAYIDA BULUNMAMAKTADIR ";
                        ror.Show();
                    }
                    else
                    {
                        PL.FRM_SATIS ADDFSATIS = new FRM_SATIS();
                        ADDFSATIS.Aktif_Kullanci_ID = this.Aktif_Kullanci_ID;
                        ADDFSATIS.btnSatis.ButtonText = "Satış Yap";
                        ADDFSATIS.txtKitapIDliste.Enabled = false;
                        ADDFSATIS.txtKitapIDliste.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                        ADDFSATIS.Guncel_Kitap_Sayisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value) - 1;
                        bunifuTransition1.ShowSync(ADDFSATIS);
                    }

                }
                if (State == "ODUNC")
                {
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("İade etme durumda kitap bulunmamaktadır");

                    }
                    else
                    {
                        PL.FRM_DDELETE DELETE_OD = new FRM_DDELETE();
                        int sayi_Kitap = BLKITAP.KITAP_SAYISI_GETIR(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
                        int kitap_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                        BLODUNC.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));

                        ///  Insert_Gecmis_Odunc
                        BLODUNC.Insert_Gecmis_Odunc(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value),
                            Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value),
                            Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value), DateTime.Now);

                        /// Kitap sayisi güncelleme
                        BLKITAP.Kitap_Sayisi_Guncelleme(kitap_ID, ++sayi_Kitap);
                        DELETE_OD.Lb_Title.Text = "İADE İŞLEMİ BAŞARIYLA TAMAMLANDI";
                        DELETE_OD.Show();
                    }


                }

                if (State == "SATIS")
                {

                    PL.FRM_DDELETE DELETE_OD = new FRM_DDELETE();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("İade etme durumda kitap bulunmamaktadır");

                    }
                    else
                    {
                        int sayi_Kitap = BLKITAP.KITAP_SAYISI_GETIR(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value));
                        int kitap_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                        BLSATIS.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                        BLKITAP.Kitap_Sayisi_Guncelleme(kitap_ID, ++sayi_Kitap);
                        DELETE_OD.Lb_Title.Text = "İADE İŞLEMİ BAŞARIYLA TAMAMLANDI";
                        DELETE_OD.Show();
                    }


                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            PL.FRM_ERRORINSERT ror = new FRM_ERRORINSERT();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için Listede Kayıt bulunmamaktadır");
            }
            else
            {
                if (State == "BOOK")
                {
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value) == 0)
                    {
                        ror.Lb_Title.Text = "!!!UYARI !!! \n İSTEDİĞİNİZ KİTAP ŞUANDA \n KÜTÜPHANEDE YETERLİ SAYIDA BULUNMAMAKTADIR ";
                        ror.Show();
                    }
                    else
                    {
                        PL.FRM_ADDODUNC ADDODUNC = new FRM_ADDODUNC();
                        ADDODUNC.Aktif_Kullanci_ID = this.Aktif_Kullanci_ID;
                        ADDODUNC.btnOdunc.ButtonText = "Ödünç Yap";
                        ADDODUNC.txtOduncKitapIDliste.Enabled = false;
                        ADDODUNC.txtOduncKitapIDliste.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                        ADDODUNC.Guncel_Kitap_Sayisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value) - 1;
                        bunifuTransition1.ShowSync(ADDODUNC);
                    }

                }

                ///  Ödünç işlermleri için ayrıntıların raporu
                if (State == "ODUNC")
                {       // ödünç raporu elde etmek için
                    PL.FRM_AYRINTILAR AYRINTI = new FRM_AYRINTILAR();
                    BL.CLC_ODUNC odunc = new BL.CLC_ODUNC();
                    DataTable dt = new DataTable();
                    string st;
                    DateTime tarih;
                    AYRINTI.baslik.Text = "Ödünç Raporu";
                    int ogrenciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    int kullanciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                    int kitapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

                    dt = odunc.AyrintiGetir(ogrenciID, kullanciID, kitapID);

                    AYRINTI.ogrenciAdi.Text = Convert.ToString(dt.Rows[0]["ogrenciAdi"]) + " " + Convert.ToString(dt.Rows[0]["ogrenciSoyad"]);
                    AYRINTI.KitapAdi.Text = Convert.ToString(dt.Rows[0]["kitapAdi"]);
                    AYRINTI.kullanciAdi.Text = Convert.ToString(dt.Rows[0]["uyeAdi"]) + " " + Convert.ToString(dt.Rows[0]["uyeSoyad"]);
                    AYRINTI.ogrenciBolum.Text = Convert.ToString(dt.Rows[0]["bolum"]);

                    AYRINTI.ogrenciId.Text = Convert.ToString(ogrenciID);
                    AYRINTI.kullanciId.Text = Convert.ToString(kullanciID);
                    AYRINTI.KitapId.Text = Convert.ToString(kitapID);

                    tarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                    st = tarih.Day + "." + tarih.Month + "." + tarih.Year;
                    AYRINTI.baslamaTarih.Text = st;

                    AYRINTI.bitisTarih_satisID.Text = "Bitiş Tarihi";
                    tarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                    st = tarih.Day + "." + tarih.Month + "." + tarih.Year;
                    AYRINTI.bitisTarih.Text = st;
                    bunifuTransition1.ShowSync(AYRINTI);
                }

                if (State == "SATIS")
                {       // satış raporu elde etmek için
                    PL.FRM_AYRINTILAR AYRINTI = new FRM_AYRINTILAR();
                    BL.CLC_SATIS satis = new BL.CLC_SATIS();
                    DataTable dt = new DataTable();
                    string st;
                    DateTime tarih;
                    AYRINTI.baslik.Text = "Satış Raporu";

                    int satis_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    dt = satis.AyrintiGetir(satis_ID);

                    AYRINTI.ogrenciAdi.Text = Convert.ToString(dt.Rows[0]["ogrenciAdi"]) + " " + Convert.ToString(dt.Rows[0]["ogrenciSoyad"]);
                    AYRINTI.KitapAdi.Text = Convert.ToString(dt.Rows[0]["kitapAdi"]);
                    AYRINTI.kullanciAdi.Text = Convert.ToString(dt.Rows[0]["uyeAdi"]) + " " + Convert.ToString(dt.Rows[0]["uyeSoyad"]);

                    AYRINTI.ogrenciId.Text = Convert.ToString(dt.Rows[0]["ogrenci_ogrenciID"]);
                    AYRINTI.kullanciId.Text = Convert.ToString(dt.Rows[0]["uyeler_uyeID"]);
                    AYRINTI.KitapId.Text = Convert.ToString(dt.Rows[0]["kitaplar_kitapID"]);

                    AYRINTI.baslaTarih_SatisTarih.Text = "Satış Tarihi";
                    tarih = Convert.ToDateTime(dt.Rows[0]["satisTarihi"]);
                    st = tarih.Day + "." + tarih.Month + "." + tarih.Year;
                    AYRINTI.baslamaTarih.Text = st;

                    AYRINTI.bitisTarih_satisID.Text = "Satış ID";
                    AYRINTI.bitisTarih.Text = Convert.ToString(dt.Rows[0]["satisID"]);
                    bunifuTransition1.ShowSync(AYRINTI);

                    AYRINTI.txt_kitap_Fiyat.Visible = true;
                    AYRINTI.kitap_Fiyat.Visible = true;

                    AYRINTI.kitap_Fiyat.Text = Convert.ToString(dt.Rows[0]["kirapFiyati"]);
                }
            }
        }

        private void OduncSayisi_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void OduncSayisi_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button18_Click(sender, e);
            }
        }

        private void OduncSayisi_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button14_Click(sender, e);
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button17_Click(sender, e);
            }
        }

        private void KategoriSayisi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KategoriSayisi_DoubleClick(object sender, EventArgs e)
        {
            if(this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button16_Click(sender, e);
            }
            
        }

        private void panel5_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button15_Click(sender, e);
            }
        }

        private void KullanciSayisi_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Çalışan" && this.Aktif_Kullanci_Yetkisi != "Öğrenci" )
            {
                button13_Click_2(sender, e);
            }
        }

        private void panel4_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button8_Click(sender, e);
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Aktif_Kullanci_Yetkisi != "Öğrenci")
            {
                button9_Click(sender, e);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setcolor(); // color change
            button10.BackColor = Color.FromArgb(00, 00, 28);
            Lb_Title.Text = "Geçmiş Ödünç";
            Button_Visible_false();
            P_HOME.Visible = false;
            P_MAIN.Visible = true;

            // Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLODUNC.load_Gecmis_Odunc();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Iade Etme Tarihi";
                dataGridView1.Columns[2].HeaderText = "Öğrenci NO";
                dataGridView1.Columns[3].HeaderText = "Kullancı ID";
                dataGridView1.Columns[4].HeaderText = "Kitap ID";
                dataGridView1.Columns[5].HeaderText = "Başlama Tarihi";
                dataGridView1.Columns[6].HeaderText = "Bitiş Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // işlemlerin Button  (ekleme - silme - düzeltme - satış - ödünç - ayrıntıları)
        public void Button_Visible_false()
        {
            bunifuThinButton21.Visible = false;
            bunifuThinButton24.Visible = false;
            bunifuThinButton23.Visible = false;
            bunifuThinButton22.Visible = false;
            btnSatisIslemi.Visible = false;
        }

        // bölünlerin button  (Ana sayfa - Kitaplar - Kategori - Öğrenci - Kullanıcı - Yazar - Yayın ev - ödünç - Satış - Geçmiş Ödünç)
        public void Bolum_Button_Visible_false()
        {
            button1.Visible = false;
           
            button18.Visible = false;
          
            button16.Visible = false;
          
            button15.Visible = false;
          
            button14.Visible = false;
            
            button13.Visible = false;
           
            button17.Visible = false;
            
            button8.Visible = false;
         
            button9.Visible = false;
           
            button10.Visible = false;
          

        }
        // bolum button change color - defualt
        public void setcolor()
        {
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button18.BackColor = Color.FromArgb(0, 0, 64);
            button16.BackColor = Color.FromArgb(0, 0, 64);
            button15.BackColor = Color.FromArgb(0, 0, 64);
            button14.BackColor = Color.FromArgb(0, 0, 64);
            button13.BackColor = Color.FromArgb(0, 0, 64);
            button17.BackColor = Color.FromArgb(0, 0, 64);
            button8.BackColor = Color.FromArgb(0, 0, 64);
            button9.BackColor = Color.FromArgb(0, 0, 64);
            button10.BackColor= Color.FromArgb(0, 0, 64);


        }

        // Ana sayfada bulunan ekleme Buttonlari
        public void Anasayfa_Button_Visible_false()
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (State == "BOOK")
            {
                this.Kitap_satir_Renklendirme();
            }
            if (State == "ODUNC")
            {
                this.Odunc_satir_Renklendirme();
            }
            if (State == "STUDENT")
            {
                this.Ogrenci_Satir_Renklendirme();
            }
        }
    }
}
