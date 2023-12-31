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
    public partial class FRM_ADDKITAP : Form
    {
        public int ID;
        public FRM_ADDKITAP()
        {
            InitializeComponent();
        }

        private void FRM_ADDKITAP_Load(object sender, EventArgs e)
        {
            try
            {
                int uzunluk;
                BL.CLC_KITAP CLKITAP = new BL.CLC_KITAP();
                DataTable dt = new DataTable();

                // Kategoriler getirmek
                dt = CLKITAP.LOAD_KATEGORI();
                uzunluk = dt.Rows.Count;
                object[] kategori_adilari = new object[uzunluk];
                int i;
                for (i = 0; i < uzunluk; i++)
                {
                    kategori_adilari[i] = dt.Rows[i]["kategoriAdi"];
                }
                txtKitapKategori.Items.AddRange(kategori_adilari);

                /// yayzarlar getirmek
                dt = CLKITAP.LOAD_YAZAR();
                uzunluk = dt.Rows.Count;
                object[] yazar_adilari = new object[uzunluk];
     
                for (i = 0; i < uzunluk; i++)
                {
                    yazar_adilari[i] = dt.Rows[i]["yazarAdi"];
                }
                txtKitapYazar.Items.AddRange(yazar_adilari);

                /// yayın evleri getirmek
                dt = CLKITAP.LOAD_YAYIN_EV();
                uzunluk = dt.Rows.Count;
                object[] yayinEv_adilari = new object[uzunluk];

                for (i = 0; i < uzunluk; i++)
                {
                    yayinEv_adilari[i] = dt.Rows[i]["yayinEviAdi"];
                }
                txtKitapYayinEv.Items.AddRange(yayinEv_adilari);

            }
            catch
            {

            }
            

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (txtKitapAd.Text == "" || txtKitapKategori.Text == "" || txtKitapAdet.Text == "" || txtKitapYayinEv.Text == "" || txtKitapYayinTarihi.Text == "" || txtKitapYazar.Text == "")
            {
                PL.FRM_ERRORINSERT Ferror = new FRM_ERRORINSERT();
                Ferror.Show();
            }
            else
            {
                if (ID == 0)
                {
                    /// add
                    BL.CLC_KITAP BLLITAP = new BL.CLC_KITAP();
                    BLLITAP.Insert(txtKitapAd.Text.Trim(), txtKitapYayinTarihi.Text.Trim(), txtKitapFiyat.Text.Trim(), txtKitapAdet.Text.Trim(), txtKitapYayinEv.Text.Trim(), txtKitapKategori.Text.Trim(), txtKitapYazar.Text.Trim());
                    PL.FRM_DADD Fadd = new FRM_DADD();
                    if (BLLITAP.durum==1)
                    {
                        Fadd.Show();
                        this.Close();
                    }
                    
                }
                else
                {
                    /// edit
                    BL.CLC_KITAP BLKITAP = new BL.CLC_KITAP();
                    BLKITAP.Update(txtKitapAd.Text.Trim(), txtKitapYayinTarihi.Text.Trim(), txtKitapFiyat.Text.Trim(), txtKitapAdet.Text.Trim(), txtKitapYayinEv.Text.Trim(), txtKitapKategori.Text.Trim(), txtKitapYazar.Text.Trim(), ID);
                    PL.FRM_DEDIT Fedit = new FRM_DEDIT();
                    if (BLKITAP.durum == 1)
                    {
                        Fedit.Show();
                        this.Close();
                    }
                }

            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_ADDCAT BLCAT = new FRM_ADDCAT();
            BLCAT.Show();

            
        }
    }
}
