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

            #region Diğer Sorgulama Fonksiyonları

            #region Count
            //Olusturulan sorguların execute edilmesi neticesinde kac adet satirin elde edileceğini
            //sayisal olarak (int) bize veren fonksiyondur

            //var sonuc = (context.Employees.ToList()).Count();
            //Console.WriteLine($"Employee Tablosunda {sonuc} adet kayit vardır");

            #endregion


            #region LongCount
            //var sonuc = (context.Employees.ToList()).LongCount();
            //Console.WriteLine($"Employee Tablosunda {sonuc} adet kayit vardır");
            #endregion

            #region Any
            //Sorgu sonucunda verinin gelip gelmediğini bool türünden dönen fonksiyondur


            //var sonuc = (context.Employees.ToList()).Any();
            //Console.WriteLine($"Employee Tablosunda kayit vardır {sonuc}");



            #endregion

            #region Max,Min
            //Max verilen kolondaki max değerini getirir

            //var sonuc = (context.Products.Max(p => p.UnitPrice));
            //Console.WriteLine($"Urunler Tablosunda en pahalı urun : {sonuc}");

            //var sonuc2 = (context.Products.Min(p => p.UnitPrice));
            //Console.WriteLine($"Urunler Tablosunda en ucuz urun : {sonuc2}");

            #endregion

            #region Distinct
            //Sorgudaki kayıtları tekilleştirir
            //var sonuc2 = context.Products.Distinct().ToList();
            //Console.WriteLine(sonuc2);
            #endregion


            #region Sum
            //Vermiş olduğumuz sayısal propertynin toplamını alır
            //var sonuc2 = (context.Products.Sum(p => p.UnitPrice));
            //Console.WriteLine($"Urunler Tablosunda toplam fiyat: {sonuc2}");
            #endregion

            #region Avarege

            //var sonuc2 = (context.Products.Average(p => p.UnitPrice));
            //Console.WriteLine($"Urunler Tablosunda fiyat ortalaması : {sonuc2}");
            #endregion

            #region Contains

            //context.Products
            //    .Where(p => p.ProductName.Contains("a"))
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));

            #endregion
            #region Startwith, EndWith

            // Like "% % " sorgusu olusturmaya yarar 

            //context.Products
            //    .Where(p => p.ProductName.StartsWith("a"))  // A ile başlayan
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));

            //Console.WriteLine("*****************************");

            //context.Products
            //    .Where(p => p.ProductName.EndsWith("a"))  // A ile biten
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));
            #endregion

            #region Select
            //Select metodu generate edilecek sorgunun cekilecek kolonlarını ayarlamanıza yarar
            //Tek kolon secilecekse
            //var urunler = context.Products.Select(p => p.ProductName).ToList();

            ////Birden fazka kolon secilecek ise
            //context.Products.Select(p => new
            //{ p.ProductId, p.ProductName, p.UnitPrice })
            //   .ToList().ForEach(p =>
            //   Console.WriteLine(p.ProductId + " " + p.ProductName + " " + p.UnitPrice));

            #endregion

            #region Group By
            // Gruplama yapmaya yarar

            //Metod Syntax
            //var urunler = context.Products.GroupBy(p => p.CategoryId).Select(group => new
            //{
            //    CategoryId = group.Key,
            //    count = group.Count(),

            //})
            //    .ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.CategoryId + " " + item.count);
            //}


            //Query Syntax
            //var data = (from urun in context.Products
            //            group urun by urun.CategoryId
            //           into @group
            //            select new
            //            {
            //                CategoryId = @group.Key,
            //                Adet = @group.Count()
            //            }).ToList();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.CategoryId + " " + item.Adet);
            //}


            #endregion
            #endregion

        }
    }
}