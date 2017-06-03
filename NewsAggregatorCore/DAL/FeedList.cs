using System;
using System.Collections.Generic;
namespace NewsAggregatorCore.DAL
{
    public class FeedList
    {
        public FeedList()
        {
        }
        public IEnumerable<FeedDetail> Feeds { get; set; }
    }
}
