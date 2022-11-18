
using Dapper;
using System.Data.SqlClient;

namespace DapperConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true";

            #region Klasik ADO.NET
            /*
     Klasik Ado.Net ile Northwind Database'indeki Shippers(Kargucular) Tablosunu cekelim
     Bunun icin 1- SqlConnection Gerekli 
                2- SqlDbCommand Gerekli
                3- SqlDataReader gerekli

     */
            //string sql = "Select * from Shippers";

            //SqlConnection connection = new SqlConnection(constr);
            //connection.Open();
            //SqlCommand command = new SqlCommand(sql, connection);
            //SqlDataReader dataReader= command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    Console.WriteLine(dataReader["ShipperId"] + " " 
            //                        + dataReader["CompanyName"] + " "
            //                        + dataReader["Phone"]);
            //}
            //connection.Close();

            #endregion



            #region Dapper https://www.learndapper.com

            #region Dapper Normal Sorgu
            //using (SqlConnection conn = new SqlConnection(constr))
            //{
            //    var result = conn.Query<Shipper>("Select * from Shippers");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"{item.ShipperId}  {item.CompanyName} {item.Phone}");
            //    }
            //} 
            #endregion



            #region Dapper Scaller Value 
            //using (var connection = new SqlConnection(constr))
            //{
            //    var sql = "select count(*) from products";
            //    var count = connection.ExecuteScalar(sql);
            //    Console.WriteLine($"Total products: {count}");
            //}

            #endregion


            #region Dapper SingleRow Dynamics
            //using (var connection = new SqlConnection(constr))
            //{
            //    var sql = "select * from products where productid = 1";
            //    var product = connection.QuerySingle(sql);
            //    Console.WriteLine($"{product.ProductID} {product.ProductName}");
                

            //    Console.ReadLine();
            //}
            #endregion
            #region Dapper SingleRow

            using (var connection = new SqlConnection(constr))
            {
                var sql2 = "select * from products where productid = 1";
                var product = connection.QuerySingle<Product>(sql2);
                Console.WriteLine($"{product.ProductId} {product.ProductName}");
                
            }

            #endregion



            #region Dapper Select Multiple Row

            //using (SqlConnection conn = new SqlConnection(constr))
            //{
            //    var result = conn.Query<Customer>("Select * from Customers");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"{item.CustomerId}  {item.CompanyName} {item.Phone}");
            //    }
            //}

            #endregion


            #region Dapper MultipleRow with Parameters

            //using (var connection = new SqlConnection(constr))
            //{

            //    var parameters = new { Country = "USA"};
            //    var sql = "select * from Customers where Country = @Country ";
            //    var result = connection.Query<Customer>(sql, parameters);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"{item.CompanyName}  {item.Country} " );
            //    }
            //}

            #endregion


            #region Dapper StoredProcedure
            var parameters = new DynamicParameters( new
                {
                Beginning_Date = new DateTime(1996, 1, 1),
                Ending_Date = new DateTime(1996, 12, 31)
            });
            var sql = "exec [Sales By Year] @Beginning_Date, @Ending_Date";
            using (var connection = new SqlConnection(constr))
            {
                var results = connection.Query(sql, parameters);
                foreach (var item in results)
                {
                    Console.WriteLine($"{item.Year} {item.OrderID}");
                }
            }



            #endregion



            #region Dapper ExecuteNonQuery
            //var sql = "insert into categories (CategoryName) values ('New Category')";
            //using (var connection = new SqlConnection(constr))
            //{
            //    var affectedRows = connection.Execute(sql);
            //    Console.WriteLine($"Affected Rows: {affectedRows}");

            //    var sonuc = connection.Query("Select CategoryID , CategoryName from Categories");
            //    foreach (var item in sonuc)
            //    {
            //        Console.WriteLine($"{item.CategoryId} {item.CategoryName} ");
            //    }

            //}

            #endregion



            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}