using EfCoreBahis.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.Entites.Concrete
{
    

    public class BahisKonusu:BaseEntity
    {
        public string BahisAciklama { get; set; }

        public bool? Acikmi { get; set; } = true;

        public DateTime KapanisSaati { get; set; }

        public List<Oynanan> Oyuncular { get; set; }

        public List<BahisCesit> BahisCesitleri { get; set; }

    }
}
