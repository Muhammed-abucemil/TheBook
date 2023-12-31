﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thebook.BL
{
    class CLC_OGRENCI
    {
        public int hata;

        // veri tabana bağlamak için daha
        // önce yazdığımız sınıfa ait bir nesne
        DAL.CLS_DAL DAL = new DAL.CLS_DAL();

        // LOAD DATA Öğrenciler
        public DataTable load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADOGRENCI", pr);
            return dt;
        }

        // Search DATA Öğrenciler
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SEARCHOGRENCI", pr);
            return dt;
        }

        //INSERT DATA Öğrenciler
        public void Insert(int ogrenciID ,string ogrenciAdi, string ogrenciSoyad, String ogrenciTel, string ogrenciKayitTarihi, string bolum)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("ogrenciAdi", ogrenciAdi);
            pr[1] = new SqlParameter("ogrenciSoyad", ogrenciSoyad);
            pr[2] = new SqlParameter("ogrenciTel", ogrenciTel);
            pr[3] = new SqlParameter("@ogrenciKayitTarih", Convert.ToDateTime(ogrenciKayitTarihi));
            pr[4] = new SqlParameter("ogrenciID", ogrenciID);
            pr[5] = new SqlParameter("bolum", bolum);

            DAL.open();
            DAL.Excute("P_ADDOGRENCI", pr);
            DAL.close();
        }


        //UPDATE DATA Öğrenciler
        public void Update(string ogrenciAdi, string ogrenciSoyad, String ogrenciTel, string bolum, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("ogrenciAdi", ogrenciAdi);
            pr[1] = new SqlParameter("ogrenciSoyad", ogrenciSoyad);
            pr[2] = new SqlParameter("ogrenciTel", ogrenciTel);
            pr[3] = new SqlParameter("ogrenciID", ID);
            pr[4] = new SqlParameter("bolum", bolum);

            DAL.open();
            DAL.Excute("P_EDITOGRENCI", pr);
            DAL.close();
        }

        //DELETE DATA Öğrenciler
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ogrenciID", ID);
            DAL.open();
            DAL.Excute("P_DELETOGRENCI", pr);
            this.hata = DAL.hata;
            DAL.close();
        }
    }
}

// bu Sınıfta , oğrenci tablosu üzerinde
// ekleme,silme ve düzeltme gibi işlemleri yapmak için 
