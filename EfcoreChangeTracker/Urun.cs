using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfcoreChangeTracker
{
    public class Urun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public int? Adet { get; set; }
        public float?  Fiyat { get; set; }
    }
}
