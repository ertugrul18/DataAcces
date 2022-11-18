using EfCoreSinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.Concrete
{
    public class Hafta:BaseEntity<Guid>
    {
        public string HaftaAdi { get; set; }

        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }


        public ICollection<Gosterim>? Gosterimler { get; set; }
    }
}
