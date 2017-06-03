using System;
using System.Collections.Generic;
using NewsAggregatorCore.DAL;
using log4net;
using System.Linq;

namespace NewsAggregatorCore.Providers
{
    public class FeedProvider : IFeedProvider
    {
        ILog log = LogManager.GetLogger(typeof(FeedProvider));
        public FeedProvider()
        {
        }

        public bool AddFeed(string feedName, string feedUrl, string feedSource)
        {
            var feedDetail = new FeedDetail()
            {
                Id = new Guid(),
                FeedUrl = feedUrl,
                FeedName = feedName,
                FeedSource = feedSource
            };
            return AddFeed(feedDetail);
        }

        public bool AddFeed(FeedDetail feedDetail)
        {
            try
            {
                using (var context = new FeedDbContext())
                {
                    context.Feeds.Add(feedDetail);

                }
                return true;
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            return false;
        }

        public IEnumerable<FeedDetail> GetFeeds()
        {
            try
            {
                using (var context = new FeedDbContext())
                {
                    return context.Set<FeedDetail>().ToArray();

                }

            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            return Enumerable.Empty<FeedDetail>();
        }

        public bool RemoveFeed(Guid feedId)
        {
            try
            {
                using (var context = new FeedDbContext())
                {
                    var feedItem = context.Feeds.First(p => p.Id == feedId);
                    if (feedItem != null)
                        context.Feeds.Remove(feedItem);
                    else
                        log.Info($"{feedId} does not exits.");

                }
                return true;
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            return false;
        }

        public bool RemoveFeed(string feedName)
        {
            try
            {
                using (var context = new FeedDbContext())
                {
                    var feedItem = context.Feeds.First(p => p.FeedName == feedName);
                    if (feedItem != null)
                        context.Feeds.Remove(feedItem);
                    else
                        log.Info($"{feedName} does not exits.");

                }
                return true;
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            return false;
        }

        public bool RemoveFeed(FeedDetail feedDetail)
        {
            try
            {
                using (var context = new FeedDbContext())
                {
                    context.Feeds.Remove(feedDetail);

                }
                return true;
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            return false;
        }
    }
}
