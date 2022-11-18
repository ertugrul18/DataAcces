using EfCoreKalitim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKalitim.Concrete
{
    public class Sinif:BaseEntity
    {
        public string? SinifAdi { get; set; }
        public int? Kapasite { get; set; }
    }
}
