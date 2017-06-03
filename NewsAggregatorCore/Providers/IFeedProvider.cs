using System;
using System.Collections.Generic;
using NewsAggregatorCore.DAL;

namespace NewsAggregatorCore.Providers
{
    public interface IFeedProvider
    {
        IEnumerable<FeedDetail> GetFeeds();

        bool AddFeed(string feedName, string feedUrl, string feedSource);

        bool AddFeed(FeedDetail feedDetail);

        bool RemoveFeed(Guid feedId);

        bool RemoveFeed(string feedName);

        bool RemoveFeed(FeedDetail feedDetail);

    }
}
