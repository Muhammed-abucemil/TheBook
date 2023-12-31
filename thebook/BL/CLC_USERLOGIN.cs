﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thebook.BL
{
    class CLC_USERLOGIN
    {
        public int hata;
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // Search DATA
        public DataTable Search(string kullanciID, string sifre)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("uyeID", kullanciID);
            pr[1] = new SqlParameter("sifre", sifre);
            DataTable dt = new DataTable();
            dt = DAL.read("P_USERLOGIN", pr);
            this.hata = DAL.hata;           // hata kontrolu
            return dt;
        }

        // sisteme öğrenci girişi  kontrolu
        public DataTable Ogrenci_Giris(string ogrenciID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@ogrenciID", ogrenciID);
            DataTable dt = new DataTable();
            dt = DAL.read("P_Ogrenci_LOGIN", pr);
            this.hata = DAL.hata;           // hata kontrolu
            return dt;
        }
    }
}
