using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserActivitySummary
    {
        private readonly User r_LoggedInUser;

        public UserActivitySummary(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser ?? throw new ArgumentNullException(nameof(i_LoggedInUser));
        }

        private static DateTime getStartDateByTimeRange(eTimeRangeOptions i_TimeRange)
        {
            return DateTime.Now.AddDays((int)i_TimeRange);
        }

        public Dictionary<DateTime, int> GetAllCategoriesSummary(eTimeRangeOptions i_TimeRange)
        {
            List<IActivityAnalyzer> analyzers = new List<IActivityAnalyzer>
            {
                ActivityAnalyzerFactory.CreateActivityAnalyzer(eAnalyzerCategory.Posts),
                ActivityAnalyzerFactory.CreateActivityAnalyzer(eAnalyzerCategory.Albums),
                ActivityAnalyzerFactory.CreateActivityAnalyzer(eAnalyzerCategory.Events)
            };

            return getCombinedActivity(analyzers, i_TimeRange);
        }

        private Dictionary<DateTime, int> getCombinedActivity(IEnumerable<IActivityAnalyzer> i_Analyzers, eTimeRangeOptions i_TimeRange)
        {
            Dictionary<DateTime, int> singleAnalyzerResult;
			Dictionary<DateTime, int> combinedSummary = new Dictionary<DateTime, int>();

            foreach (IActivityAnalyzer analyzer in i_Analyzers)
            {
                singleAnalyzerResult = analyzer.Analyze(r_LoggedInUser, i_TimeRange);

				foreach (KeyValuePair<DateTime, int> entry in singleAnalyzerResult)
                {
                    if (!combinedSummary.ContainsKey(entry.Key))
                    {
                        combinedSummary[entry.Key] = 0;
                    }

                    combinedSummary[entry.Key] += entry.Value;
                }
            }

            return combinedSummary;
        }

        public Dictionary<DateTime, int> GetDataForCategory(eAnalyzerCategory i_Category, eTimeRangeOptions i_TimeRange)
        {
            IActivityAnalyzer analyzer = ActivityAnalyzerFactory.CreateActivityAnalyzer(i_Category);

            return analyzer.Analyze(r_LoggedInUser, i_TimeRange);
        }

        public static Dictionary<DateTime, int> FilterItemsByDate<T>(
            IEnumerable<T> i_Items,
            Func<T, DateTime?> i_ExtractDate,
            eTimeRangeOptions i_TimeRange)
        {
            Dictionary<DateTime, int> activityByDate = new Dictionary<DateTime, int>();
            DateTime startDate = getStartDateByTimeRange(i_TimeRange);
            DateTime? itemDate;

            foreach (T item in i_Items)
            {
                itemDate = i_ExtractDate(item);
                if (itemDate.HasValue && itemDate.Value >= startDate)
                {
                    DateTime date = itemDate.Value.Date;

                    if (!activityByDate.ContainsKey(date))
                    {
                        activityByDate[date] = 0;
                    }

                    activityByDate[date]++;
                }
            }

            return activityByDate;
        }
    }
}
