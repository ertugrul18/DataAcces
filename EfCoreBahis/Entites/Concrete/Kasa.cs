using EfCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.Entites.Concrete
{
    public class Kasa:BaseEntity
    {
        public string KasaAdi { get; set; }
        public double ToplamBakiye { get; set; }

        public List<KasaHareket> KasaHareketleri { get; set; }
    }
}
