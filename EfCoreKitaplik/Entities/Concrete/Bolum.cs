using EfCoreKitaplik.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Entities.Concrete
{
    public class Bolum:BaseEntity<Guid>
    {
        public string BolumAdi { get; set; }

        public ICollection<Raf>? Raflar { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
