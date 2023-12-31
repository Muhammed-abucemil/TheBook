﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thebook.PL
{
    
    public partial class FRM_LOGIN : Form
    {
        // kullanici arayüzü Giris_status=1  / öğrenci arayüzü Giris_status=0
        private int Giris_status=1;
        public FRM_LOGIN()
        {
            InitializeComponent();
            txtKullancıSifre.PasswordChar = '*';
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            if (Giris_status == 1)
            {
                Kullanici_Giris();
            }
            else
            {
                Ogrenci_Giris();
            }
        }

        private void txtKullancıSifre_Enter(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Firebrick;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.IndianRed;
        }


        // Password Show / Hide 
        private void pass_show_Click(object sender, EventArgs e)
        {
            if(txtKullancıSifre.PasswordChar == '*')
            {
                txtKullancıSifre.PasswordChar = '\0';
            }
            else
            {
                txtKullancıSifre.PasswordChar = '*';
            }
            
        }

        // sisteme giriş giriş durumu   Kullanıcı / Öğrenci
        private void label1_Click(object sender, EventArgs e)
        {
            if(label1.Text.Trim()== "Öğrenci Giriş")
            {
                label1.Text = "Kullanıcı Girişi";
                Password_template_false();
                this.Giris_status = 0;

            }
            else
            {
                label1.Text = "Öğrenci Giriş";
                this.Giris_status = 1;
                Password_template_true();
            }
            
        }

        //Password_template_false
        public void Password_template_false()
        {
            txtKullancıSifre.Visible = false;
            pictureBox2.Visible = false;
            pass_show.Visible = false;
        }

        //Password_template_true
        public void Password_template_true()
        {
            txtKullancıSifre.Visible = true;
            pictureBox2.Visible = true;
            pass_show.Visible = true;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Firebrick;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.IndianRed;
        }

        private void txtKullancıSifre_Enter_1(object sender, EventArgs e)
        {

        }

        // Ogrenci Girişi
        public void Ogrenci_Giris()
        {
            if (txtKullanciAd.Text == "")
            {

                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                txtKullanciAd.Text = txtKullanciAd.Text.Trim();

                DataTable dt = new DataTable();
                BL.CLC_USERLOGIN BLUSER = new BL.CLC_USERLOGIN();
                dt = BLUSER.Ogrenci_Giris(txtKullanciAd.Text);

                if (BLUSER.hata != 0 && dt.Rows.Count > 0)
                {

                    PL.FRM_MAIN PLMAIN = new FRM_MAIN();
                    PLMAIN.Aktif_Kullanci_ID = Convert.ToInt32(dt.Rows[0][0]);
                    PLMAIN.Aktif_Kullanci_Yetkisi ="Öğrenci";
                    PLMAIN.Bolum_Button_Visible_false();
                    PLMAIN.Anasayfa_Button_Visible_false();
                    PLMAIN.Button_Visible_false();
                    PLMAIN.button1.Visible = true;
                    PLMAIN.button18.Visible = true;
                    PLMAIN.button16.Visible = true;
                    PLMAIN.Show();
                    this.Hide();
                }
                else
                {
                    PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                    Ferror.Lb_Title.Text = "HATA // SİSTEMDE KAYITLI DEĞİLSİNİZ - veya Öğrenci\n No Yanlış Girdiniz!!";
                    Ferror.Show();
                }
            }

        }

        // Kullanıcı Girişi
        public void Kullanici_Giris()
        {
            if (txtKullanciAd.Text == "" || txtKullancıSifre.Text == "")
            {

                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                txtKullanciAd.Text = txtKullanciAd.Text.Trim();
                txtKullancıSifre.Text = txtKullancıSifre.Text.Trim();

                DataTable dt = new DataTable();
                BL.CLC_USERLOGIN BLUSER = new BL.CLC_USERLOGIN();
                dt = BLUSER.Search(txtKullanciAd.Text, txtKullancıSifre.Text);

                if (BLUSER.hata != 0 && dt.Rows.Count > 0)
                {

                    PL.FRM_MAIN PLMAIN = new FRM_MAIN();
                    PLMAIN.Aktif_Kullanci_ID = Convert.ToInt32(dt.Rows[0][0]);
                    PLMAIN.Aktif_Kullanci_Yetkisi = Convert.ToString(dt.Rows[0][6]);
                    PLMAIN.Show();
                    this.Hide();
                }
                else
                {
                    PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                    Ferror.Lb_Title.Text = "HATA // SİSTEMDE KAYITLI DEĞİLSİNİZ \n \n \nVEYA KULLANCI ID / ŞİFRE YANLIŞ GİRİDİNİZ !!";
                    Ferror.Show();
                }
            }
        }
    }
}
