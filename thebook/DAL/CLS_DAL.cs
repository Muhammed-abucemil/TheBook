using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace thebook.DAL
{
    class CLS_DAL
    {
        PL.FRM_ERRORINSERT ERROR = new PL.FRM_ERRORINSERT();

        public int hata=1;
        /// <summary>
        /// hata değişkeni  ,varsayılan değeri (1), yani başlangıçta işlemleri  doğru olduğunu  kabul edelim
        /// Bu değişken veritaban üzerinde  Ekleme , Silme ve Düzeltme gibi işlemler
        /// yapılırken hata oluştuğunda bilgilendirmek için kullanılan bir değişken
        /// </summary>

        SqlConnection con = new SqlConnection();

        public CLS_DAL()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-M2OG6JB\SQLEXPRESS;Initial Catalog=thebook;Integrated Security=True");
        }

        /// bu metod veritabanla bağlanti kurmak içın
        public void open()
        {
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
            }
        }
        /// bu metod veritabanla bağlanti kesmek içın
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // bu metod veritabandan veri okumak için

        public DataTable read(String store ,SqlParameter[] pr)
        {
            try
            {
                hata = 1;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = store;
                if (pr != null)
                {
                    cmd.Parameters.AddRange(pr);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                this.hata = 0;
                return null;
            }

            

        }


        //  Bu metod veritaban üzerinde  Ekleme , Silme ve Düzeltme gibi işlemler yapmak için

        public void Excute(String store , SqlParameter[] pr)
        {
            try
            {
                hata = 1;   ///     yani başlangıçta işlemleri  doğru olduğunu  kabul edelim
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = store;
                if (pr != null)
                {
                    cmd.Parameters.AddRange(pr);
                }
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                hata = 0; /// hata olduğunda değişkenin değeri (0) olacak
            }

        }




    }
}
