﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace thebook.BL
{
    class CLC_ODUNC
    {
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();
        public int hata;
        // LOAD DATA
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSATIODUNC", pr);
            return dt;
        }

        // Search DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHODUNC", pr);
            return dt;
        }

        //INSERT DATA Ödünç İŞLEMİ
        public void Insert(int uyeID, int ogrenciID, int kitapID, DateTime baslamaTarih, DateTime bitisTarih)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("uyeID", uyeID);
            pr[1] = new SqlParameter("ogrenciID", ogrenciID);
            pr[2] = new SqlParameter("kitapID", kitapID);
            pr[3] = new SqlParameter("baslamaTarih", baslamaTarih);
            pr[4] = new SqlParameter("bitisTarih", bitisTarih);
            DAL.open();
            DAL.Excute("P_ADDODUNC", pr);
            this.hata = DAL.hata;        // hata kontrolu
            DAL.close();
        }


        //UPDATE DATA SATIŞ İŞLEMİ
        public void Update(int ogrenciID, int kitapID, int kullanciID, DateTime baslamaTarihi, DateTime bitisTarihi)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("ogrenciID", ogrenciID);
            pr[1] = new SqlParameter("kitapID", kitapID);
            pr[2] = new SqlParameter("kullanciID", kullanciID);
            pr[3] = new SqlParameter("baslamaTarihi", baslamaTarihi);
            pr[4] = new SqlParameter("bitisTarihi", bitisTarihi);
            DAL.open();
            DAL.Excute("P_EDITODUNC", pr);
            DAL.close();
        }

        //DELETE DATA SATIŞ İŞLEMİ
        public void Delete(int ogrenciID, int kitapID)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("ogrenciID", ogrenciID);
            pr[1] = new SqlParameter("kitapID", kitapID);
            DAL.open();
            DAL.Excute("P_DELETODUNC", pr);
            DAL.close();
        }

        //  Kitaplar ID ComboBox'e getirmek için 
        public DataTable LOAD_KITAP_ID()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("P_COMBOBOX_KITAP_ID", pr);
            return dt;
        }
        //  Öğrenciler ID ComboBox'e getirmek için 
        public DataTable LOAD_OGRENCI_ID()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("P_COMBOBOX_OGRENCI_ID", pr);
            return dt;
        }

        //ödünç ayrıntıları getirmek
        public DataTable AyrintiGetir(int ogrenciID, int kullanciID , int kitapID)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter("ogrenciID", ogrenciID);
            pr[1] = new SqlParameter("kitapID", kitapID);
            pr[2] = new SqlParameter("kullanciID", kullanciID);

            DataTable dt = new DataTable();
            dt = DAL.read("P_ODUNC_AYRINTI_GETIR", pr);
            return dt;
        }

        // öğrenci ödünüç olarak aldığı kitap sayısı
        public DataTable Odubc_Kitap_sayisi(int ogrenciID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ogrenciID", ogrenciID);

            DataTable dt = new DataTable();
            dt = DAL.read("P_ODUNC_Kitap_sayisi", pr);
            return dt;
        }

        //INSERT DATA - iade edilen kitaplar geçmiş ödünç tablosuna aktarmak için kullanılan metod
        public void Insert_Gecmis_Odunc(int ogrenciID, int uyeID, int kitapID, DateTime baslamaTarih, DateTime bitisTarih, DateTime iade_Etme_Tarihi)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("uyeID", uyeID);
            pr[1] = new SqlParameter("ogrenciID", ogrenciID);
            pr[2] = new SqlParameter("kitapID", kitapID);
            pr[3] = new SqlParameter("baslamaTarih", baslamaTarih);
            pr[4] = new SqlParameter("bitisTarih", bitisTarih);
            pr[5] = new SqlParameter("iade_Etme_Tarihi", iade_Etme_Tarihi);
            DAL.open();
            DAL.Excute("P_ADD_GECMIS_ODUNC", pr);
            this.hata = DAL.hata;        // hata kontrolu
            DAL.close();
        }

        // LOAD DATA geçmiş ödünç tablosu
        public DataTable load_Gecmis_Odunc()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOAD_GECMIS_ODUNC", pr);
            return dt;
        }

    }
}
