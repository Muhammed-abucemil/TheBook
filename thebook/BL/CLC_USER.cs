﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace thebook.BL
{
    class CLC_USER
    {
        public int hata;

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA KULLANCILAR
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUSER", pr);
            return dt;
        }

        // Search DATA KULLANCILAR
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHUSER", pr);
            return dt;
        }

        //INSERT DATA KULLANCILAR
        public void Insert(string uyeAdi, string uyeSoyad ,String uyeEmail,
            string uyeTel , string uyeAdresi,string uyeYetkisi ,string sifre)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("@uyeAdi", uyeAdi);
            pr[1] = new SqlParameter("@uyeSoyad", uyeSoyad);
            pr[2] = new SqlParameter("@uyeEmail", uyeEmail);
            pr[3] = new SqlParameter("@uyeTel", uyeTel);
            pr[4] = new SqlParameter("@uyeAdresi", uyeAdresi);
            pr[5] = new SqlParameter("@uyeYetkisi", uyeYetkisi);
            pr[6] = new SqlParameter("@sifre", sifre);
            DAL.open();
            DAL.Excute("P_ADDUSER", pr);
            DAL.close();
        }


        //UPDATE DATA KULLANCILAR
        public void Update(string uyeAdi, string uyeSoyad,String uyeEmail
            ,String uyeTel , String uyeAdresi , string uyeYetkisi,  int ID)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("uyeAdi", uyeAdi);
            pr[1] = new SqlParameter("uyeSoyad", uyeSoyad);
            pr[2] = new SqlParameter("uyeEmail", uyeEmail);
            pr[3] = new SqlParameter("uyeTel", uyeTel);
            pr[4] = new SqlParameter("uyeAdresi", uyeAdresi);
            pr[5] = new SqlParameter("uyeYetkisi", uyeYetkisi);
            pr[6] = new SqlParameter("uyeID", ID);

            DAL.open();
            DAL.Excute("P_EDITUSER", pr);
            DAL.close();
        }

        //DELETE DATA KULLANCILAR
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("uyeID", ID);
            DAL.open();
            DAL.Excute("P_DELETUSER", pr);
            this.hata = DAL.hata;
            DAL.close();
        }
    }
}
// bu class , uyeler tablosu üzerinde belli işlemleri yapmak için 
