﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
	public abstract class EntityBase
	{
		public int Id { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
	}
}
