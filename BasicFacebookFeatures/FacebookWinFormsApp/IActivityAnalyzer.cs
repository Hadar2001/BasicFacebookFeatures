using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IActivityAnalyzer
    {
        Dictionary<DateTime, int> Analyze(User i_User, eTimeRangeOptions i_TimeRange);
    }
}