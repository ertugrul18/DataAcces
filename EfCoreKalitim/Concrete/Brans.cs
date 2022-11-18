using EfCoreKalitim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKalitim.Concrete
{
    public class Brans:BaseEntity
    {
        public string? BransAdi { get; set; }
        public ICollection<Ogretmen> Ogretmenler { get; set; }
    }
}
