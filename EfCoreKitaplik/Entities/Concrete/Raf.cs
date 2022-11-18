using EfCoreKitaplik.Entities.Abstract;

namespace EfCoreKitaplik.Entities.Concrete
{
    public class Raf:BaseEntity<Guid>
    {
        public string RafNo { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }

        public Guid? BolumId { get; set; }

        public Bolum? Bolum { get; set; }
    }
}