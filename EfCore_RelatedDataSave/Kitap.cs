using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_RelatedDataSave
{
    public class Kitap
    {
        public Kitap()
        {
            Yazarlar = new HashSet<Yazar>();
        }
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public ICollection<Yazar> Yazarlar { get; set; }
    }
}
