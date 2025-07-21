using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class PostActivityAnalyzer : IActivityAnalyzer
    {
        public Dictionary<DateTime, int> Analyze(User i_User, eTimeRangeOptions i_TimeRange)
        {
            FacebookObjectCollection<Post> posts =
                DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<Post>("posts");

            return UserActivitySummary.FilterItemsByDate(
                posts,
                post => post.CreatedTime,
                i_TimeRange);
        }
    }
}