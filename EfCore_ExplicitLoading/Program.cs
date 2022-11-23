namespace EfCore_ExplicitLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NorthwindContext context = new NorthwindContext();
            //var urun = context.Products.FirstOrDefault(p => p.ProductId == 1);
            /* Explicit Loading: Olusturulan sorguya eklenecek verilerin sartlara bagli olarak , 
             * ihtiyaclara istinade yuklenmesi olayi gerceklestiren bir yaklasimdir 
              
             */


            /*
             
             Bu arada başka kodlar oldugunu farzedelim
             */

            // Eger bulunan entity'nin daha sonrasinda siparislerini istersek eger 
            // asagidaki gibi bir calisma yapmamiz gerekir. 
            //if (urun.ProductId == 1)
            //{
            //    var siparisleri = context.OrderDetails.Where(o => o.ProductId== 1).ToList();
            //    foreach (var item in siparisleri)
            //    {
            //        global::System.Console.WriteLine(item.OrderId + " " + item.UnitPrice+ " " + item.Quantity);
            //    }
            //}

            #region  Referans 

            // Explicit Yaklasimda iliskisel olarak sorguya eklenmek istenen tablonun navigation property'si eger ki tekil ise
            // Referans Metodu kullanilir. Sonrasinda Load Etmeyi unutmayin
            //context.Entry(urun).Reference(p => p.Category).Load();
            //context.Entry(urun).Reference(p => p.Supplier).Load();

            //Console.WriteLine(urun.Category.CategoryName +
            //    " "  + urun.Supplier.ContactName);


            #endregion

            #region Collection Oldugu Durumlarda
            // Explicit Yaklasimda iliskisel olarak sorguya eklenmek istenen tablonun navigation property'si eger ki cogul/ICollection ise
            // Collection Metodu kullanilir. Sonrasinda Load Etmeyi unutmayin


            //context.Entry(urun).Collection(p => p.OrderDetails).Load();

            //foreach (var orderDetail in urun.OrderDetails.ToList()) 
            //{
            //    global::System.Console.WriteLine("Fiyat :"+orderDetail.UnitPrice + "  Adet:" + orderDetail.Quantity);
            //}

            #endregion

            #region Collection'lar uzerinde Aggregate Operator uygulamak

            //var kayitsayisi = context.Entry(urun).Collection(p => p.OrderDetails).Query().Count();
            //var Ciro = context.Entry(urun).Collection(p => p.OrderDetails).Query().Sum(p=>p.Quantity*p.UnitPrice);
            //Console.WriteLine("Kayi Sayisi:"+kayitsayisi + " Ciro:"+Ciro.ToString("C2"));

            #endregion

            #region Collection'lara Filtre uygulamak
            // 50 dolardan yuksek olan urunlarin satis cirosu
            //var sonuc = context.Entry(urun).Collection(p => p.OrderDetails).Query().Where(p =>p.Quantity>5).Sum(p => p.Quantity * p.UnitPrice);
            //Console.WriteLine("Sonuc:"+sonuc);
            #endregion



            Console.WriteLine("Hello, World!");
        }
    }
}