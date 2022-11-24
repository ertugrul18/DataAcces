using EfCore_Lab.Entities;

namespace EfCore_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();


            #region Musterilerin Cirolarını Explicit Loading ile çıkartalım
            //var musteriler = context.Customers.ToList();
            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine($"Musteri Adi:{musteri.CompanyName}   Ulke:{musteri.Country} Sehir:{musteri.City}");
            //    context.Entry(musteri).Collection(p => p.Orders).Load();

            //    foreach (var order in musteri.Orders)
            //    {
            //        context.Entry(order).Collection(p => p.OrderDetails).Load();

            //        foreach (var orderdetail in order.OrderDetails)
            //        {
            //            Console.WriteLine("\t\t\t\n");

            //            context.Entry(orderdetail).Reference(p => p.Product).Load();
            //            Console.WriteLine($@"urun :{orderdetail.Product.ProductName} Siparis Adedi:{orderdetail.Quantity}  Fiyat:{orderdetail.UnitPrice} Toplam Tutar:{orderdetail.UnitPrice * orderdetail.Quantity}");
            //        }


            //    }
            //}

            /*
            Musteri Adi  Ulke: USA  Sehir: NewYork

           siparis tarihi 01.01.1996 1256 numaralı siparisin detayları aşağıdadır.
               Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
               Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
               Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL

           siparis tarihi 01.01.1996 1256 numaralı siparisin detayları aşağıdadır.
               Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
               Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
               Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
          */

            #endregion

            #region Çalışanların siparişlere göre cirolarını  çıkartın Explicit Loading
            //var calisanlar = context.Employees.ToList();

            //foreach (var calisan in calisanlar)
            //{
            //    Console.WriteLine($"Çalısan Adi: {calisan.FirstName + "" + calisan.LastName} Ulke: {calisan.Country} Sehir: {calisan.City} ");
            //    context.Entry(calisan).Collection(p => p.Orders).Load();

            //    foreach (var order in calisan.Orders)
            //    {
            //        context.Entry(order).Collection(p => p.OrderDetails).Load();

            //        foreach (var orderDetail in order.OrderDetails)
            //        {
            //            Console.WriteLine("\t\t\t\n");

            //            context.Entry(orderDetail).Reference(p => p.Product).Load();
            //            Console.WriteLine($@"Urun: {orderDetail.Product.ProductName} Siparis Adeti: {orderDetail.Quantity}  Fiyat: {orderDetail.UnitPrice} Toplam Tutar:{orderDetail.UnitPrice * orderDetail.Quantity}");

            //        }
            //    }
            //}

            /*
           Çalışan Adi: Nancy Davalio  Ulke: USA  Sehir: NewYork

          siparis tarihi 01.01.1996 1256 numaralı siparisin detayları aşağıdadır.
              Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
              Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
              Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL

          siparis tarihi 01.01.1996 1256 numaralı siparisin detayları aşağıdadır.
              Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
              Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
              Siparis verilen urun: Ekmek  Siparis Adedi: 10 Fiyat: 5 Toplam  Tutar:50  İndirim: discount:0.9 İndirimli Toplam Tutar : 45TL
         */
            #endregion

        }
    }
}

