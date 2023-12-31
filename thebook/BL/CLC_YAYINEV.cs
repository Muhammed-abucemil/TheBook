﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace thebook.BL
{
    class CLC_YAYINEV
    {
        public int hata;

        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA Yayın Ev
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADYAYINEV", pr);
            return dt;
        }

        // Search DATA Yayın Ev
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHYAYINEV", pr);
            return dt;
        }

        //INSERT DATA Yayın Ev
        public void Insert(string yayinEviAdi, string yayinEviAdresi, String yayinEviTel)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter("yayinEviAdi", yayinEviAdi);
            pr[1] = new SqlParameter("yayinEviTel", yayinEviTel);
            pr[2] = new SqlParameter("yayinEviAdresi", yayinEviAdresi);

            DAL.open();
            DAL.Excute("P_ADDYAYINEV", pr);
            DAL.close();
        }


        //UPDATE DATA Yayın Ev
        public void Update(string yayinEviAdi, string yayinEviAdresi, String yayinEviTel, int ID)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("@yayinEviAdi", yayinEviAdi);
            pr[1] = new SqlParameter("@yayinEviAdresi", yayinEviAdresi);
            pr[2] = new SqlParameter("@yayinEviTel", yayinEviTel);
            pr[3] = new SqlParameter("@yayinEviID", ID);

            DAL.open();
            DAL.Excute("P_EDITYAYINEV", pr);
            DAL.close();
        }

        //DELETE DATA Yayın Ev
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@yayinEviID", ID);
            DAL.open();
            DAL.Excute("P_DELETYAYINEV", pr);
            this.hata = DAL.hata;        // hata kontrolu
            DAL.close();
        }
    }
}

// bu class , YAYIN EVLERI tablosu üzerinde belli işlemleri yapmak için 
