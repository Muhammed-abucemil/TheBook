﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thebook.BL
{
    class CLC_YAZAR
    {
        public int hata;

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA YAZARLAR
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADYAZAR", pr);
            return dt;
        }

        // Search DATA YAZARLAR
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHYAZAR", pr);
            return dt;
        }

        //INSERT DATA YAZARLAR
        public void Insert(string yazarAdi, String yazarEmail, string yazarTel, string yazarAdresi)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("@yazarAdi", yazarAdi);
            pr[1] = new SqlParameter("@yazarEmail", yazarEmail);
            pr[2] = new SqlParameter("@yazarTel", yazarTel);
            pr[3] = new SqlParameter("@yazarAdresi", yazarAdresi);
      
            DAL.open();
            DAL.Excute("P_ADDYAZAR", pr);
            DAL.close();
        }


        //UPDATE DATA YAZARLAR
        public void Update(string yazarAdi, String yazarEmail, String yazarTel, String yazarAdresi, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("yazarAdi", yazarAdi);
            pr[1] = new SqlParameter("yazarEmail", yazarEmail);
            pr[2] = new SqlParameter("yazarTel", yazarTel);
            pr[3] = new SqlParameter("yazarAdresi", yazarAdresi);
            pr[4] = new SqlParameter("yazarID", ID);

            DAL.open();
            DAL.Excute("P_EDITYAZAR", pr);
            DAL.close();
        }

        //DELETE DATA YAZARLAR
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@yazarID", ID);
            DAL.open();
            DAL.Excute("P_DELETYAZAR", pr);
            this.hata = DAL.hata;            // hata kontrolu
            DAL.close();
        }

    }
}
// bu class , uyeler tablosu üzerinde belli işlemleri yapmak için 
