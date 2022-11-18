using EfCoreKalitim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKalitim.Concrete
{
    public class Ogretmen:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? GSM { get; set; }

        public string? Email { get; set; }
        public Cinsiyet? Cinsiyet { get; set; }

        public int BransId { get; set; }
        public Brans Brans { get; set; }
    }
}
