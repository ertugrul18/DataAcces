namespace EfCore_RelatedDataSave
{
    public class Yazar
    {
        public Yazar()
        {
            Kitaplar = new HashSet<Kitap>();
        }
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }

    }
}