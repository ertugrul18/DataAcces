using EfCore_RelatedData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EfCore_RelatedData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            #region Eager Loading

            //Eager Loading generate edilen sorguya ilişkisel verilerin parça parça
            //eklenmesini sağlayan ve bunu yaparkende iradeli/istekli bir şekilde yapmamızı sağlayan yöntemdir

            // var calisanlar = context.Employees.ToList();

            #endregion

            #region Include
            //Olusturulan sorguya ilişkili verileri dahil edilmesini sağlayan metotdur
            //1.yöntem ınclude metotuna string ifade gecilerek yapılır
            // var calisanlar2 = context.Employees.Include("Orders").ToList();
            //2.Yöntem ise


            //var calisanlar3 = context.Employees.
            //    Where(p => p.Orders.Count > 10).
            //    Include(p => p.Orders).
            //    ToList();
            #endregion

            #region ThenInclude
            /*
             ThenInclude urewtilen sorguda include edilen tablolarin iliskili oldugu diger tablolarida 
             Sorguya ekleyebilmek icin kullanilan Metot'tur
            Eger ki include ediln navigation propertisi kolleksiyonel bir yapiya sahipse . 
            o tablodaki iliskili diger verileri getirmeye yarar.
             */


            //var musteriler = context.Customers
            //    .Include(p => p.Orders)
            //    .ThenInclude(e => e.OrderDetails)
            //    .ToList();
            #endregion

            //Musterilerin siparisler ,
            //siparislerin detaylari ve detaydaki urunleri getirir
            //var musteriler2 = context.Customers
            //    .Include(p => p.Orders)
            //    .ThenInclude(e => e.OrderDetails)
            //    .ThenInclude(p=>p.Product)
            //    .ToList();


            #region 1997 yilida alinmis siparisler ,detaylariyla beraber sorgulayin
            //var sonuclar = context.Orders
            //                        .Where(p => p.OrderDate.Value.Year == 1997)
            //                        .Include(p => p.OrderDetails)
            //                        .ThenInclude(p=>p.Product)
            //                        .ToList();
            //foreach (var item in sonuclar)
            //{
            //    Console.WriteLine(item.OrderId + " " + item.OrderDate + " "+ item.ShipCountry+ " " + item.ShipCity);
            //    foreach (var detay in item.OrderDetails)
            //    {
            //        Console.WriteLine(detay.Product.ProductName + " " + detay.UnitPrice+ " " + detay.Quantity);
            //    }

            //    global::System.Console.WriteLine("---------------------------");
            //}

            #endregion


            #region Musterilerin Siparis Adetleri nedir

            //var musteriler = context.Customers.Include(p=>p.Orders).ToList();   

            //foreach (var musteri in musteriler) 
            //{
            //    global::System.Console.WriteLine(musteri.CompanyName + "   "  + musteri.Country );
            //    var siparisSayisi = musteri.Orders.Count;
            //    global::System.Console.WriteLine("Toplam Siparis Sayisi:"+siparisSayisi);
            //}

            #endregion

            #region Musterilerin Siparis Cirolari nedir ?

            // Query syntax
            //var musteriler = (from cust in context.Customers
            //                 join order in context.Orders on cust.CustomerId equals order.CustomerId
            //                 join dt in context.OrderDetails on order.OrderId equals dt.OrderId
            //                 where order.OrderDate.Value.Year == 1997
            //                 select  cust).ToList();

            //Metot Syntax
            #endregion




            #region Filtered Include
            //Metod Syntax
            //var musteriler2 = context.Customers
            //                    .Include(p => p.Orders.Where(t => t.OrderDate.Value.Year == 1997))
            //                    .ThenInclude(p => p.OrderDetails)
            //                    .ToList();
            //decimal ciro = 0;
            //foreach ( var cust in musteriler2.ToList() ) 
            //{


            //    foreach (var item in cust.Orders)
            //    {
            //        foreach (var item2 in item.OrderDetails)
            //        {
            //            ciro += (item2.UnitPrice * item2.Quantity);

            //        }
            //    }
            //    Console.WriteLine(cust.CustomerId + " "+cust.CompanyName + " "+ cust.Country +" Ciro:" + ciro);

            //    ciro = 0;
            //}


            #endregion

            #region EagerLoadin ile ilgili ek bilgi.

            /*
             Eger Daha onceden calistirilmis sorgumuz hafizada var ise
              EfCore Gerekli iliskileri kurark size include islemi yapmadan verileri sunacaktir.
             */

            //var sipdetay = context.OrderDetails.ToList();
            //var siparisler = context.Orders.ToList();
            //var musteriler = context.Customers.ToList();


            //var sorgu = context.Customers
            //    .Include(p => p.Orders)
            //    .ThenInclude(l => l.OrderDetails)
            //    .ToList();

            #endregion


            #region AutoInclude EfCore-6
            /*
             DbContext nesnesi icerisinde gerekli tanimlamalar yapilmalidir.
             */
            // var urunler = context.Products.ToList();

            #endregion

            #region IgnoreAutoInclude

            //  var urunler = context.Products.IgnoreAutoIncludes().ToList();
            #endregion


            #region Musterilerin Siparis Cirolari nedir ?

            // Query syntax
            //var musteriler = (from cust in context.Customers
            //                 join order in context.Orders on cust.CustomerId equals order.CustomerId
            //                 join dt in context.OrderDetails on order.OrderId equals dt.OrderId
            //                 where order.OrderDate.Value.Year == 1997
            //                 select  cust).ToList();

            //Metot Syntax





            #endregion

            #region Kategorilerin Cirolari Nedir
            //var kategori = context.Categories.Include(p => p.Products).ThenInclude(o => o.OrderDetails).ToList();
            //decimal ciro = 0;
            //foreach (var item in kategori)
            //{
            //    foreach (var item2 in item.Products)
            //    {
            //        foreach (var item3 in item2.OrderDetails)
            //        {
            //            ciro += (item3.UnitPrice * item3.Quantity);
            //        }
            //    }
            //    Console.WriteLine("Kategori " + item.CategoryName);
            //    Console.WriteLine(ciro);
            //    ciro = 0;

            //}
            #endregion


            #region Kargo Firmalarinin Tasidigi Siparis sayisi nedir

            //var kargocular = context.Shippers.Include(p => p.Orders)
            //  .ThenInclude(p => p.OrderDetails).ToList();

            //decimal adet = 0;

            //foreach (var item in kargocular)
            //{
            //    foreach (var item2 in item.Orders)
            //    {
            //        foreach (var item3 in item2.OrderDetails)
            //        {
            //            adet += item3.Quantity;
            //        }


            //    }

            //    Console.WriteLine(item.CompanyName + " " + adet);
            //    adet = 0;
            //    }

            //}

            #endregion


            #region Calisanlarin Aldigi Toplam Siparis Sayisi nedir

            //    var calısanlar = context.Employees.Include(p => p.Orders)
            //      .ThenInclude(p => p.OrderDetails).ToList();

            //    decimal adet = 0;

            //    foreach (var item in calısanlar)
            //    {
            //        foreach (var item2 in item.Orders)
            //        {
            //            foreach (var item3 in item2.OrderDetails)
            //            {
            //                adet += item3.Quantity;
            //            }


            //        }

            //        Console.WriteLine(item.FirstName + " " + adet);
            //        adet = 0;
            //    }

            //}


            #endregion


            #region Calisanlarin Toplam Cirolari nedir 

            //var calısanlar = context.Employees.Include(p => p.Orders).ThenInclude(o => o.OrderDetails).ToList();
            //decimal ciro = 0;
            //foreach (var item in calısanlar)
            //{
            //    foreach (var item2 in item.Orders)
            //    {
            //        foreach (var item3 in item2.OrderDetails)
            //        {
            //            ciro += (item3.UnitPrice * item3.Quantity);
            //        }
            //    }
            //    Console.WriteLine("Calısanların Ciroları : " + item.FirstName + " " + item.LastName);
            //    Console.WriteLine(ciro);
            //    ciro = 0;

            //}

            #endregion


            #region Urunlerin Satis Adetleri Ve Cirolari nedir


            var urunler = context.Products.Include(p => p.OrderDetails).ToList();
            decimal ciro = 0;
            decimal adet = 0;

            foreach (var item in urunler)
            {
                foreach (var item2 in item.OrderDetails)
                {
                    ciro += (item2.UnitPrice * item2.Quantity);
                    adet += item2.Quantity;
                }
                Console.WriteLine("Urunlerin Satıs adetleri ve ciroları  " + item.ProductName);
                Console.WriteLine("Ciro " + ciro + " " + "Adet " + adet);
                ciro = 0;
                adet = 0;
            }

            #endregion

        }

    }
}
