using EfCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.Entites.Concrete
{
    public class BahisCesitDetay:BaseEntity
    {
        public int BahisCesitId { get; set; }
        public BahisCesit BahisCesit { get; set; }
        public int OynananId { get; set; }
        public Oynanan Oynanan { get; set; }

        public double Oran { get; set; } = 1;
    }
}
