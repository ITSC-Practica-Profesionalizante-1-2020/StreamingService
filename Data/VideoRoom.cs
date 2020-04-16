using System;
using System.Collections.Generic;

namespace Data
{
	public class VideoRoom : EntityBase
	{
		public List<IUser> Users { get; set; }
		public IUser Owner { get; set; }
		public string Name { get; set; }
		public TimeSpan Duration { get; set; }

	}
}
