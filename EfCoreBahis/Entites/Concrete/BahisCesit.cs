using EfCoreBahis.Entites.Abstract;

namespace EfCoreBahis.Entites.Concrete
{
    public class BahisCesit:BaseEntity
    {
        public string Aciklama { get; set; }

        //BahisKonusu ile bire cok iliskilidir
        public int BahisKonusuId { get; set; }
        public BahisKonusu BahisKonusu { get; set; }

       

    }
}