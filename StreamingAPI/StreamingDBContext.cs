using Microsoft.EntityFrameworkCore;
using SharedModels.StreamingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingAPI
{
	public class StreamingDBContext : DbContext
	{
		public StreamingDBContext(DbContextOptions<StreamingDBContext> options)
			: base(options)
		{ }

		public DbSet<VideoRoom> VideoRooms { get; set; }
		public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }

	}
}
