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
    public partial class FRM_ADDODUNC : Form
    {
        public int ID;
        public int Aktif_Kullanci_ID;
        public int Guncel_Kitap_Sayisi;
        public FRM_ADDODUNC()
        {
            InitializeComponent();
        }

        private void FRM_ADDODUNC_Load(object sender, EventArgs e)
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
            txtOduncKitapIDliste.Items.AddRange(kitap_ID);

            /// Ogrenciler getirmek
            dt = CLSATIS.LOAD_OGRENCI_ID();
            uzunluk = dt.Rows.Count;
            object[] Ogrenci_ID = new object[uzunluk];

            for (i = 0; i < uzunluk; i++)
            {
                Ogrenci_ID[i] = dt.Rows[i]["ogrenciID"];
            }
            txtOduncOgrenciIDListe.Items.AddRange(Ogrenci_ID);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();

            if (txtOduncKitapIDliste.Text == "" || txtOduncOgrenciIDListe.Text == "" || Aktif_Kullanci_ID == 0)
            {
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_ODUNC BLODUNC = new BL.CLC_ODUNC();

                    if (BLODUNC.Odubc_Kitap_sayisi(Convert.ToInt32(txtOduncOgrenciIDListe.Text.Trim())).Rows.Count < 5)
                    {
                        BLODUNC.Insert(Aktif_Kullanci_ID, Convert.ToInt32(txtOduncOgrenciIDListe.Text.Trim()), Convert.ToInt32(txtOduncKitapIDliste.Text.Trim()), Convert.ToDateTime(txtOdunBaslaTarih.Text.Trim()), Convert.ToDateTime(txtOdunBitisTarih.Text.Trim()));

                        if (BLODUNC.hata != 0)
                        {
                            BL.CLC_KITAP BLKITAP = new BL.CLC_KITAP();
                            BLKITAP.Kitap_Sayisi_Guncelleme(Convert.ToInt32(txtOduncKitapIDliste.Text.Trim()), this.Guncel_Kitap_Sayisi);
                            PL.FRM_DADD Fadd = new FRM_DADD();
                            Fadd.Show();
                            this.Close();
                        }
                        else
                        {
                            
                            Ferror.Lb_Title.Text = "HATA// BU İŞLEM DAHA ÖNCE YAPILDI !! ";
                            Ferror.Show();
                        }
                    }
                    else
                    {
                        Ferror.Lb_Title.Text = "!!! UYARI !!! \n  Seçtiğiniz Öğrenci alabileceği en \n fazla kitap sayısı durumuna ulaştı ";
                        Ferror.Show();
                    }
                    
                    
                }
                else
                {
                    /// edit
                    BL.CLC_ODUNC BLODUNC = new BL.CLC_ODUNC();
                    BLODUNC.Update(Convert.ToInt32(txtOduncOgrenciIDListe.Text.Trim()), Convert.ToInt32(txtOduncKitapIDliste.Text.Trim()),Aktif_Kullanci_ID,Convert.ToDateTime(txtOdunBaslaTarih.Text.Trim()), Convert.ToDateTime(txtOdunBitisTarih.Text.Trim()));
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    Fedit.Show();
                    this.Close();
                }

            }
        }
    }
}
