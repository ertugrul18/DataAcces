using CodeFirstConApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDbContext context = new MyDbContext();
            //Kategori kategori = new Kategori();
            //Product product = new Product();
            

            context.Database.MigrateAsync();
            Console.WriteLine("Hello, World!");
        }
    }

   
}