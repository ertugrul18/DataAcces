using EfCoreKitaplik.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Entities.Concrete
{
    public class Kitap:BaseEntity<Guid>
    {
        public string KitapAdi { get; set; }
        public DateTime?   BaskiTarihi { get; set; }
        public string? ISBN { get; set; }
       public ICollection<Yazar> Yazarlar { get; set; }



        public Guid? RafId { get; set; }
        public Raf? Raf { get; set; }

        public Guid? BolumId { get; set; }
        public Bolum? Bolum { get; set; }


    }
}
