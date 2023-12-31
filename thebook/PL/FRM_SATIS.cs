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
    public partial class FRM_SATIS : Form
    {
        public int ID;
        public int Aktif_Kullanci_ID;
        public int Guncel_Kitap_Sayisi;
        public int hata = 1;
        public FRM_SATIS()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
            
        {
            if (txtKitapIDliste.Text == "" || txtOgrenciIDListe.Text == "" || Aktif_Kullanci_ID == 0 )
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_SATIS BLSATIS = new BL.CLC_SATIS();
                    BLSATIS.Insert(Aktif_Kullanci_ID,Convert.ToInt32(txtOgrenciIDListe.Text.Trim()), Convert.ToInt32(txtKitapIDliste.Text), Convert.ToDateTime(txtSatisTarih.Text));
                    BL.CLC_KITAP BLKITAP = new BL.CLC_KITAP();
                    if (BLSATIS.hata != 0)
                    {
                        BLKITAP.Kitap_Sayisi_Guncelleme(Convert.ToInt32(txtKitapIDliste.Text), this.Guncel_Kitap_Sayisi);
                        PL.FRM_DADD Fadd = new FRM_DADD();
                        Fadd.Show();
                        this.Close();
                    }
                    else
                    {
                        PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                        Ferror.Lb_Title.Text = "!!! UYARI !!! \nSeçtiğiniz Öğrenci No sistemde Kayıtlı Değil";
                        Ferror.Show();
                    }
                    
                }
                else
                {
                    /// edit
                    BL.CLC_SATIS BLSATIS = new BL.CLC_SATIS();
                    BLSATIS.Update(Convert.ToInt32(txtOgrenciIDListe.Text.Trim()), Convert.ToDateTime(txtSatisTarih.Text), ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_SATIS_Load(object sender, EventArgs e)
        {
            int uzunluk;
            BL.CLC_SATIS CLSATIS = new BL.CLC_SATIS();
            DataTable dt = new DataTable();

            // Kitaplar getirmek
            dt = CLSATIS.LOAD_KITAP_ID();
            uzunluk = dt.Rows.Count;
            object[] kitap_ID = new object[uzunluk];
            int i;
            for (i = 0; i < uzunluk; i++)
            {
                kitap_ID[i] = dt.Rows[i]["kitapID"];
            }
            txtKitapIDliste.Items.AddRange(kitap_ID);

            /// Ogrenciler getirmek
            dt = CLSATIS.LOAD_OGRENCI_ID();
            uzunluk = dt.Rows.Count;
            object[] Ogrenci_ID = new object[uzunluk];

            for (i = 0; i < uzunluk; i++)
            {
                Ogrenci_ID[i] = dt.Rows[i]["ogrenciID"];
            }
            txtOgrenciIDListe.Items.AddRange(Ogrenci_ID);
        }

       
    }
}
