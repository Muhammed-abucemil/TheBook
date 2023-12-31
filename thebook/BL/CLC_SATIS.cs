﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thebook.BL
{
    class CLC_SATIS
    {
        public int hata;

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSATISLAR", pr);
            return dt;
        }

        // Search DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHSATIS", pr);
            return dt;
        }

        //INSERT DATA SATIŞ İŞLEMİ
        public void Insert(int uyeID, int ogrenciID, int kitapID , DateTime satisTarihi)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("uyeID", uyeID);
            pr[1] = new SqlParameter("ogrenciID", ogrenciID);
            pr[2] = new SqlParameter("kitapID", kitapID);
            pr[3] = new SqlParameter("satisTarihi", satisTarihi);
            DAL.open();
            DAL.Excute("P_ADDSATIS", pr);
            this.hata = DAL.hata;
            DAL.close();
        }


        //UPDATE DATA SATIŞ İŞLEMİ
        public void Update(int ogrenciID, DateTime satisTarihi, int ID)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter("ogrenciID", ogrenciID);
            pr[1] = new SqlParameter("satisTarihi", satisTarihi);
            pr[2] = new SqlParameter("satisID", ID);
            DAL.open();
            DAL.Excute("P_EDITSATIS", pr);
            DAL.close();
        }

        //DELETE DATA SATIŞ İŞLEMİ
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("satisID", ID);
            DAL.open();
            DAL.Excute("P_DELETSATIS", pr);
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

        // LOAD DATA
        public DataTable AyrintiGetir(int satis_ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("satis_ID", satis_ID);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SATIS_AYRINTI_GETIR", pr);
            return dt;
        }


    }
}



// bu class , satış tablosu üzerinde belli işlemleri yapmak için 