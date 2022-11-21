using EfCoreQuery.Entities;
using System;
using System.Threading.Channels;

namespace EfCoreQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            #region Tablolarda Sorgulama

            #region Standart Sorgulama

            // Method Syntax

            //var employees = context.Employees;
            //employees.ToList();

            //Query Syntax

            //Burasi sorguyu hazırlar
            // var sonuc = from emp in context.Employees select emp;

            //Tolist ise oluşan sorguyu database'de calıştıtır.
            // sonuc.ToList().ForEach(e => Console.WriteLine(e.FirstName + " " + e.LastName));




            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //}

            #endregion
            #region Where Sarti

            //Method Yöntemi

            //   var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a"));
            //  var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a") && p.BirthDate.Value.Year >= 1960);
            //Console.WriteLine("Bir Harf Giriniz");
            //var harf = Console.ReadLine();
            //sonuclar.Where(p => p.FirstName.Contains(harf));
            //Console.WriteLine("Bir Yil Giriniz");
            //var yil = Console.ReadLine();
            //sonuclar.Where(p => p.BirthDate.Value.Year >= int.Parse(yil));

            //Query Yöntemi
            //var sonuc2 = from emp in context.Employees
            //             where emp.FirstName.Contains("a")
            //             && emp.BirthDate.Value.Year >= 1960
            //             select emp;

            //foreach (var p in sonuc2.ToList())
            //{
            //    Console.WriteLine(p.FirstName + " " + p.LastName);
            //}
            #endregion
            #region OrderBy
            //Normal order by sorgusu
            //var sonuclar = context.Employees.
            //    Where(p => p.FirstName.Contains("a")).
            //    OrderBy(p => p.FirstName).ToList();
            //Birden fazla kolona göre order by calismasi
            //var sonuclar2 = context.Employees.
            //   Where(p => p.FirstName.Contains("a")).
            //   OrderBy(p => p.FirstName).ThenBy(p => p.EmployeeId).ToList();

            //Query Syntax

            //var empoyees = from emp in context.Employees
            //               orderby emp.FirstName, emp.EmployeeId
            //               select emp;

            //foreach (var p in empoyees.ToList())
            //{
            //    Console.WriteLine(p.EmployeeId + " " + p.FirstName + " " + p.LastName);
            //}



            #endregion
            #region Order By Descending
            //Metod Yöntemi
            //var sonuclar = context.Employees.
            //    Where(p => p.FirstName.Contains("a")).
            //    OrderByDescending(p => p.FirstName).ToList();
            // Birden fazla kolona göre order by calismasi
            //var sonuclar2 = context.Employees.
            //   Where(p => p.FirstName.Contains("a")).
            //   OrderBy(p => p.FirstName).ThenBy(p => p.EmployeeId).ToList();

            //Query Syntax

            //var empoyees = from emp in context.Employees
            //               orderby emp.FirstName descending
            //               select emp;

            //foreach (var p in empoyees.ToList())
            //{
            //    Console.WriteLine(p.EmployeeId + " " + p.FirstName + " " + p.LastName);
            //}



            #endregion


            #region Tekil Veri Getiren Sorgulama Fonksiyonlari

            //Yapilan sorguda sadece bir tek verinin gelmesini istiyorsak
            //Single yada SingleOrDefault metodlari kullanilir
            #region Single , SingleOrDefault
            //Single Yada SingleAsyn metodlari eğerki sorgu sonucunda birden fazla kayit geliyorsa 
            //ya da hiç gelmiyorsa hata firlatir.

            //SingleOrDefault eğer sorgu neticesinde birden fazla kayit gelirse hata firlatir
            //hiç kayit gelmez ise null deger geri döner
            //try
            //{
            //    var sonuc = context.Employees.Where(p => p.EmployeeId == 1).Single();
            //    var sonuc2 = context.Employees.Where(p => p.EmployeeId == 45).SingleOrDefault();


            //    Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);
            //}
            //catch (Exception ex)
            //{
            //    global::System.Console.WriteLine(ex.Message);
            //} 
            #endregion
            #region First , FirstOrDefault
            //Sorguda ki verilerin ilkini getirir. Eger kayit gelmiyorsa hata firlatir

            //try
            //{
            //    //Bu sorgu düzgün çalısır
            //    var sonuc = context.Employees.First(p => p.EmployeeId == 1);
            //    global::System.Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);

            //    //Burasi hata firlaticaktır
            //    //var sonuc2 = context.Employees.First(p => p.EmployeeId == 100);
            //    //global::System.Console.WriteLine(sonuc2.FirstName + " " + sonuc2.LastName);

            //    var sonuc3 = context.Employees.FirstOrDefault(p => p.EmployeeId > 5);
            //    global::System.Console.WriteLine(sonuc3.FirstName + " " + sonuc3.LastName);

            //}
            //catch (Exception ex)
            //{
            //    global::System.Console.WriteLine(ex.Message);
            //}

            #endregion
            #region Find 
            //Find metodu primary key kolonuna göre arama yapar dolayısı
            //ile veriye daha hizli erişir

            //var sonuc = context.Employees.Find(3);
            //Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);

            #region Composite Primary Key olduğunda ne yapar?

            //var sonuc2 = context.Employees.Find(3,5);
            //Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);

            #endregion

            #endregion
            #region Last , LastOrDefault
            //Sorguda ki verilerin sonuncusunu getirir. Eger kayit gelmiyorsa hata firlatir
            //Bu sorguda OrderBy kullanılması zorunludur
            //var result = context.Employees.OrderBy(p => p.EmployeeId).Last(p => p.EmployeeId >= 3);
            //Console.WriteLine(result.FirstName + " " + result.LastName);

            //var result2 = context.Employees.OrderBy(p => p.EmployeeId).LastOrDefault(p => p.EmployeeId >= 3);
            //Console.WriteLine(result2.FirstName + " " + result2.LastName);
            #endregion


            #endregion
            #endregion

        }
    }
}