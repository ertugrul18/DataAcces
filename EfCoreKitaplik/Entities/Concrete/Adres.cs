using EfCoreKitaplik.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Entities.Concrete
{
    public class Adres:BaseEntity<Guid>
    {
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? Cadde { get; set; }

        public string? Sokak { get; set; }
        public string? KapiNo { get; set; }

        public string? PostaKodu { get; set; }

        public Guid YazarId { get; set; }
        public Yazar Yazar { get; set; }
    }
}
