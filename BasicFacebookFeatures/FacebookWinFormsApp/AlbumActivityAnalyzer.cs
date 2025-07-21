using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class AlbumActivityAnalyzer : IActivityAnalyzer
    {
        public Dictionary<DateTime, int> Analyze(User i_User, eTimeRangeOptions i_TimeRange)
        {
            FacebookObjectCollection<Album> albums =
                DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<Album>("albums");

            return UserActivitySummary.FilterItemsByDate(
                albums,
                album => album.CreatedTime,
                i_TimeRange);
        }
    }
}