using EfCore_LazyLoading.Entities;

namespace EfCore_LazyLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            /*
            Lazy (Tembel) Loading (Yukleme) : Navigation property'leri uzerinde bir islem yaptigimizda ilgili navigation peopertye karsilik gelen sorgunun 
           olusturulup execure edilmesi ve yuklenmesini saglayan yaklasimdir.
           Bunun icin Microsoft.EntityFrameworkCore.Proxies paketinin yuklenmesi gerekmektedir
           Sonrasinda DbConetxt nesnemizdeki OnConfiguring() metodunda 
           optionsBuilder.UseLazyLoadingProxies() eklenmesi gerekir
           Bu yaklasimda navigation property'lerin mutlaka virtual olmasi gerekmektedir

            */



            //var urun = context.Products.ToList();

            //foreach (var product in urun)
            //{
            //    Console.WriteLine(product.Category.CategoryName + " " + product.Supplier.CompanyName);

            //}

            //Lazy Loading, kullanım açısından oldukça maliyetli ve performans düşürücü bir
            //etkiye sahip yöntemdir. O yüzden kullanırken mümkün mertebe dikkatli olmalı ve
            //özellikle navigation propertylerin döngüsel tetiklenme durumlarında
            //lazy loading'i tercih etmemeye odaklanmalıyız. Aksi taktirde her bir
            //tetiklemeye karşılık aynı sorguları üretip execute edecektir.
            //Bu durumu N+1 Problemi olarak nitelendirmekteyiz.
            //Mümkün mertebe, ilişkisel verileri eklerken Lazy Loading kullanmamaya
            //özen göstermeliyiz.
            Console.WriteLine("Hello, World!");
        }
    }
}