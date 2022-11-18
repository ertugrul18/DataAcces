using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConApp.Entities
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string? Aciklama { get; set; }

        public ICollection<Product> Urunler { get; set; }
    }
}
