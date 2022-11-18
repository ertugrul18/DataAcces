using EfCoreSinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.Concrete
{
    public class Gosterim:BaseEntity<Guid>
    {
        public Guid? FilmId { get; set; } // Database'e burasi yansir

        public Film? Film { get; set; } // Burasi db'ye yansimaz. Bu prop NAvigation Property'sidir


        public Guid? SeansId { get; set; }
        public Seans? Seans { get; set; }

        public Guid? HaftaId { get; set; }
        public Hafta? Hafta { get; set; }


        public Guid? SalonId { get; set; }
        public Salon? Salon { get; set; }
    }
}
