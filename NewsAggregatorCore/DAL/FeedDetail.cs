using System;
namespace NewsAggregatorCore.DAL
{
    public class FeedDetail
    {
        public FeedDetail()
        {
        }

        public Guid Id { get; set; }
        public string FeedName { get; set; }
        public string FeedUrl { get; set; }
        public string FeedSource { get; set; }

    }
}
