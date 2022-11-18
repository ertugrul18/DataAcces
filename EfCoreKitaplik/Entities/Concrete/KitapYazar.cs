using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Entities.Concrete
{
    public class KitapYazar
    {
        public Guid KitapId { get; set; }
        public Kitap Kitap { get; set; }
        public Guid YazarID { get; set; }
        public Yazar Yazar { get; set; }
    }
}
