using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKalitim.Abstract
{
    public enum Status
    {
        Active=1,
        Modifiy,
        Deleted
    }

    public abstract  class BaseEntity
    {
        public int Id { get; set; }

        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate ; }
            set { _createDate =  value; }
        }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        private Status _status= Status.Active;

        public Status Status
        {
            get { return _status; }
            set { _status  = value; }
        }

    }
}
