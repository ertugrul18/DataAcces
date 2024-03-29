﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBahis.Entites.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

		private DateTime _CreateDate=DateTime.Now;

		public DateTime CreateDate
		{
			get { return _CreateDate; }
			set { _CreateDate=value; }
		}

        public DateTime? UpdateDate { get; set; }
    }
}
