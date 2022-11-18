using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplik.Entities.Abstract
{
    public enum Status:byte
    {
        Active=1,
        Deleted

    }

    public abstract class BaseEntity<T> 
    {
        public T Id { get; set; }

		private DateTime _CreateDate=DateTime.Now;

		public DateTime CreateDate
		{
			get { return _CreateDate; }
			set { _CreateDate= value; }
		}

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        private Status _Status=Status.Active;

        public Status Status
        {
            get { return _Status; }
            set { _Status= value; }
        }

    }
}
