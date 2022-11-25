using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_RelatedDataSave
{
    public class Person
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public Adress Adres { get; set; }
    }
}
