using DbFirstEFCore.Entities;

namespace DbFirstEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext context = new NorthwindContext();
            foreach (var emp in context.Employees)
            {
                Console.WriteLine(emp.FirstName  + " " + emp.LastName);
            }

            Shipper shipper = new Shipper() {CompanyName="Aras Kargo",Phone="44 0 999" };

            context.Shippers.Add(shipper);  
           int sonuc =  context.SaveChanges();
            if (sonuc > 0) 
            { 
                Console.WriteLine("Islem Basarili Verile Id:"+shipper.ShipperId); 
            }
            else Console.WriteLine("Beklenemeyen bir hata olustu");

            foreach (var kargo in context.Shippers.ToList())
            {
                Console.WriteLine(kargo.ShipperId + " " + kargo.CompanyName + " " + kargo.Phone); ;
            } 

            Console.WriteLine("Hello, World!");
        }
    }
}