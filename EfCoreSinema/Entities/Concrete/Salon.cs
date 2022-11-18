using EfCoreSinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.Concrete
{
    public class Salon:BaseEntity<Guid>
    {
        public string SalonAdi { get; set; }
        public byte? Kapasite { get; set; } = 0;


        public ICollection<Gosterim>? Gosterimler { get; set; }
    }
}
