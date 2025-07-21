using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class EventActivityAnalyzer : IActivityAnalyzer
    {
        public Dictionary<DateTime, int> Analyze(User i_User, eTimeRangeOptions i_TimeRange)
        {
            FacebookObjectCollection<Event> events =
                DataCacheManager.SingletonInstance.GetCollectionFromServiceOrCache<Event>("events");

            return UserActivitySummary.FilterItemsByDate(
                events,
                ev => ev.StartTime,
                i_TimeRange);
        }
    }
}
