using EfCoreKalitim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKalitim.Concrete
{
    public enum Cinsiyet
    {
        Bayan=1,
        Erkek
    }

    public class Ogrenci:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? Email { get; set; }
        public string? Gsm { get; set; }

        public Cinsiyet? Cinsiyet { get; set; }

        public DateTime? DogumTarihi { get; set; }
    }
}
