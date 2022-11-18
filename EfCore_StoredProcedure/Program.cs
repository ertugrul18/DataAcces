using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EfCore_StoredProcedure
{
    internal class Program
    {


        
        static void Main(string[] args)
        {
            SqlDbContext dbContext = new SqlDbContext();
            string urunadi = "Peynir";


            #region Input Parametre alan 
            // input Parametreli Kullanim
            //SqlParameter name = new SqlParameter("name", "Peynir");
            //name.Direction = System.Data.ParameterDirection.Input;
            //name.DbType = System.Data.DbType.String;
            //var liste = dbContext.Urunler.FromSql($"Exec UrunleriGetir2 {name}");

            //liste.ToList();
            //foreach (var item in liste)
            //{
            //    global::System.Console.WriteLine(item.Id + " " + item.UrunAdi);
            //}

            #endregion
            // Scaler value donmesi durumunda olacaklar

            //var sonuc = dbContext.Database.SqlQuery<int>($"Exec UrunSayisi").ToList();

            #region  EfCore Complex Stored Procedure

            var sonuc = dbContext.kategoriVeUrunler.FromSql($"Exec KategoriVeUrunleri").ToList();

            foreach (var item in sonuc)
            {
                global::System.Console.WriteLine(item.KategoriAdi + " "+ item.Adet);
            }
            #endregion


            Console.WriteLine("Hello, World!" + sonuc[0]);
        }
    }
}