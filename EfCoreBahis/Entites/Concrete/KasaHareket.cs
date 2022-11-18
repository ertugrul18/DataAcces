using EfCoreBahis.Entites.Abstract;

namespace EfCoreBahis.Entites.Concrete
{
    public enum KasaHaraketTipi:byte
    {
        Giris=1,
        Cikis=2
    }

    public class KasaHareket:BaseEntity
    {
        public int KasaId { get; set; }
        public Kasa Kasa { get; set; }

        //Foreign Key
        public int OynayanId { get; set; }
        public Oynayan Oynayan { get; set; }

        public KasaHaraketTipi HareketTipi { get; set; }
        public double Tutar { get; set; }


        //Foreign Key
        public int BahisCesitId { get; set; }
        public BahisCesit BahisCesit { get; set; }

    }
}