﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thebook.BL
{
    class CLC_KITAP
    {
        public int hata;
       
        public int durum = 1;
        /// <summary>
        /// durum değikeni
        /// Kitap üzerinde eklem veya düzeltme işlemleri yapılırken yazar,yayın ev ve kategori kontrol yapabilmek için sağlayan değişken
        /// </summary>

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADKITAP", pr);
            return dt;
        }

        // Search DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHKITAP", pr);
            return dt;
        }

        //INSERT DATA Kitap
        public void Insert(string kitapAdi, string yayinTarihi ,string kitapFiyat , string KitapAdet ,string KitapYayinEv , string KitapKategori ,string KitapYazar)
        {
            int kategoriID;
            int yayinEviID;
            int yazarID;
            PL.FRM_ERRORINSERT eor = new PL.FRM_ERRORINSERT();
            SqlParameter[] pr1 = new SqlParameter[1];
            pr1[0] = new SqlParameter("@Search", KitapYayinEv);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCH_KITAP_YAYINEV", pr1);        //// yayin ev Id getir
            if (dt.Rows.Count==0)
            {
                durum = 0;
                eor.Lb_Title.Text= "HATA // GİRDİĞİNİZ YAYIN EVIN ADI SISTEMDE BULUNMAMAKTADIR !!";
                eor.Show();
                return;
            }
            yayinEviID = Convert.ToInt32(dt.Rows[0]["yayinEviID"]) ;

            pr1[0] = new SqlParameter("@Search", KitapKategori);
            dt = DAL.read("P_SEARCH_KITAP_KATEGORI", pr1);        //// kategori Id getir
            if (dt.Rows.Count == 0)
            {
                durum = 0;
                eor.Lb_Title.Text = "HATA // GİRDİĞİNİZ KATEGORI ADI SISTEMDE BULUNMAMAKTADIR !!";
                eor.Show();
                return;
            }
            kategoriID = Convert.ToInt32(dt.Rows[0]["kategoriID"]);

            pr1[0] = new SqlParameter("@Search", KitapYazar);
            dt = DAL.read("P_SEARCH_KITAP_YAZAR", pr1);        //// Kitap Yazar Id getir
            if (dt.Rows.Count == 0)
            {
                durum = 0;
                eor.Lb_Title.Text = "HATA // GİRDİĞİNİZ YAZAR ADI SISTEMDE BULUNMAMAKTADIR !!";
                eor.Show();
                return;
            }
            yazarID = Convert.ToInt32(dt.Rows[0]["yazarID"]);

            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("@kitapAdi", kitapAdi);
            pr[1] = new SqlParameter("@yayinTarihi", Convert.ToDateTime(yayinTarihi));
            pr[2] = new SqlParameter("@kirapFiyati", Convert.ToDouble(kitapFiyat));
            pr[3] = new SqlParameter("@adet", Convert.ToInt32(KitapAdet));
            pr[4] = new SqlParameter("@yayinevleri_yayinEviID", yayinEviID);
            pr[5] = new SqlParameter("@kategori_kategoriID", kategoriID);
            pr[6] = new SqlParameter("@yazar_yazarID", yazarID);
            DAL.open();
            DAL.Excute("P_ADDKITAP", pr);
            DAL.close();


        }


        //UPDATE DATA Kitap
        public void Update(string kitapAdi, string yayinTarihi, string kitapFiyat, string KitapAdet, string KitapYayinEv, string KitapKategori, string KitapYazar, int ID)
        {
            int kategoriID;
            int yayinEviID;
            int yazarID;

            PL.FRM_ERRORINSERT eor = new PL.FRM_ERRORINSERT();
            SqlParameter[] pr1 = new SqlParameter[1];
            pr1[0] = new SqlParameter("@Search", KitapYayinEv);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCH_KITAP_YAYINEV", pr1);        //// yayin ev Id getir
            if (dt.Rows.Count == 0)
            {
                durum = 0;
                eor.Lb_Title.Text = "HATA // GİRDİĞİNİZ YAYIN EVIN ADI SISTEMDE BULUNMAMAKTADIR !!";
                eor.Show();
                return;
            }
            yayinEviID = Convert.ToInt32(dt.Rows[0]["yayinEviID"]);

            pr1[0] = new SqlParameter("@Search", KitapKategori);
            dt = DAL.read("P_SEARCH_KITAP_KATEGORI", pr1);        //// kategori Id getir
            if (dt.Rows.Count == 0)
            {
                durum = 0;
                eor.Lb_Title.Text = "HATA // GİRDİĞİNİZ KATEGORI ADI SISTEMDE BULUNMAMAKTADIR !!";
                eor.Show();
                return;
            }
            kategoriID = Convert.ToInt32(dt.Rows[0]["kategoriID"]);

            pr1[0] = new SqlParameter("@Search", KitapYazar);
            dt = DAL.read("P_SEARCH_KITAP_YAZAR", pr1);        //// Kitap Yazar Id getir
            if (dt.Rows.Count == 0)
            {
                durum = 0;
                eor.Lb_Title.Text = "HATA // GİRDİĞİNİZ YAZAR ADI SISTEMDE BULUNMAMAKTADIR !!";
                eor.Show();
                return;
            }
            yazarID = Convert.ToInt32(dt.Rows[0]["yazarID"]);


            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("@kitapAdi", kitapAdi);
            pr[1] = new SqlParameter("@yayinTarihi", Convert.ToDateTime(yayinTarihi));
            pr[2] = new SqlParameter("@kirapFiyati", Convert.ToDouble(kitapFiyat));
            pr[3] = new SqlParameter("@adet", Convert.ToInt32(KitapAdet));
            pr[4] = new SqlParameter("@yayinevleri_yayinEviID", yayinEviID);
            pr[5] = new SqlParameter("@kategori_kategoriID", kategoriID);
            pr[6] = new SqlParameter("@yazar_yazarID", yazarID);
            pr[7] = new SqlParameter("@kitapID", ID);

            DAL.open();
            DAL.Excute("P_EDITKITAP", pr);
            DAL.close();
        }

        //DELETE DATA Kitap
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("kitapID", ID);
            DAL.open();
            DAL.Excute("P_DELETKITAP", pr);
            this.hata = DAL.hata;            // hata kontrolu
            DAL.close();
        }
        //  Kategori adıları ComboBox'e getirmek için 
        public DataTable LOAD_KATEGORI()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("P_COMBOBOX_KATEGORI", pr);
            return dt;
        }
        //  Yazar adıları ComboBox'e getirmek için 
        public DataTable LOAD_YAZAR()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("P_COMBOBOX_YAZAR", pr);
            return dt;
        }
        //  Yayın ev adıları ComboBox'e getirmek için 
        public DataTable LOAD_YAYIN_EV()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("P_COMBOBOX_YAYIN_EV", pr);
            return dt;
        }

        // SATIŞ VEYA ÖDÜNÇ İŞLEMİ YAPILDIKTAN SONRA VERİ TABANDA KİTAP SAYISI GÜNCELLEMESİ
        public void Kitap_Sayisi_Guncelleme(int ID, int yeni_kitap_sayisi)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("kitapID", ID);
            pr[1] = new SqlParameter("adet", yeni_kitap_sayisi);
            DAL.open();
            DAL.Excute("P_KITAP_SAYISI_GUNCELLEME", pr);
            DAL.close();
        }

        //  Yayın ev adıları ComboBox'e getirmek için 
        public int KITAP_SAYISI_GETIR(int kitapID)
        {
            int SAYI;
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("kitapID", kitapID);
            DataTable dt = new DataTable();
            dt = DAL.read("P_KITAP_SAYISI_GETIR", pr);
            SAYI= Convert.ToInt32(dt.Rows[0]["adet"]) ;
            return SAYI;
        }

    }
}

// bu class , kitaplar tablosu üzerinde belli işlemleri yapmak için 