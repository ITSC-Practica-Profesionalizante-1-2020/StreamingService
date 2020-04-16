using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
	class ConferenceRecordFile: EntityBase
	{
		public IUser Owner { get; set; }
		public string Path { get; set; }
	}
}
