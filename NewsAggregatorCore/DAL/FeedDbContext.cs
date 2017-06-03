using System;
using System.Data.Entity;

namespace NewsAggregatorCore.DAL
{
    public class FeedDbContext : DbContext
    {
        public FeedDbContext() : base()
        {
        }
        public DbSet<FeedDetail> Feeds { get; set; }
    }
}
