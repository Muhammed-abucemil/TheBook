﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace thebook.BL
{
    class CLC_CAT
    {
        public int hata;

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADKAT", pr);
            return dt;
        }

        // Search DATA
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHCAT", pr);
            return dt;
        }

        //INSERT DATA KATEGORI
        public void Insert( string kategoriAdi, string kategoriAyrintilari)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("kategoriAdi", kategoriAdi);
            pr[1] = new SqlParameter("kategoriAyrintilari", kategoriAyrintilari);
            DAL.open();
            DAL.Excute("P_ADDCAT",pr);
            DAL.close();
        }


        //UPDATE DATA KATEGORI
        public void Update(string kategoriAdi, string kategoriAyrintilari,int ID)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter("kategoriAdi", kategoriAdi);
            pr[1] = new SqlParameter("kategoriAyrintilari", kategoriAyrintilari);
            pr[2] = new SqlParameter("kategoriID", ID);
            DAL.open();
            DAL.Excute("P_EDITCAT", pr);
            DAL.close();
        }

        //DELETE DATA KATEGORI
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("kategoriID", ID);
            DAL.open();
            DAL.Excute("P_DELETCAT", pr);
            this.hata = DAL.hata;
            DAL.close();
        }

    }
}

// bu class , kategori tablosu üzerinde belli işlemleri yapmak için 