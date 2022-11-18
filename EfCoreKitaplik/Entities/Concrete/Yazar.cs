using EfCoreKitaplik.Entities.Abstract;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Entities.Concrete
{
    public class Yazar:BaseEntity<Guid>
    {
        public string Ad { get; set; }
        public string   Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public bool? Cinsiyet { get; set; }

       // public ICollection<KitapYazar> Kitaplar { get; set; }
       public ICollection<Kitap>? Kitaplar { get; set; }
        public Adres? Adres { get; set; }
    }
}
