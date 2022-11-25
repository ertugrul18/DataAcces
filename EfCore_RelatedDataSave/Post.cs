namespace EfCore_RelatedDataSave
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}