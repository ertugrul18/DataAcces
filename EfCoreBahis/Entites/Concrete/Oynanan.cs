using EfCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.Entites.Concrete
{
    public class Oynanan:BaseEntity
    {
        public string Adi { get; set; }
        

        public double Guc { get; set; }

        public List<BahisCesit> BahisCesitleri { get; set; }
    }
}
