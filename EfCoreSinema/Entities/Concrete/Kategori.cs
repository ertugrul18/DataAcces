using EfCoreSinema.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.Entities.Concrete
{
    public class Kategori:BaseEntity<Guid>
    {
        public string KategoriAdi { get; set; }

        public string? Aciklama { get; set; }

        public ICollection<Film>? Filmler { get; set; }
    }
}
