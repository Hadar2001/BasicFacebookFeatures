using System;

namespace BasicFacebookFeatures
{
   public static class ActivityAnalyzerFactory
   {
        public static IActivityAnalyzer CreateActivityAnalyzer(eAnalyzerCategory i_AnalyzerCategory)
        {
            switch (i_AnalyzerCategory)
            {
                case eAnalyzerCategory.Posts:
                    return new PostActivityAnalyzer();
                case eAnalyzerCategory.Albums:
                    return new AlbumActivityAnalyzer();
                case eAnalyzerCategory.Events:
                    return new EventActivityAnalyzer();
                default:
                    throw new ArgumentException($"Unknown category: {i_AnalyzerCategory}");
            }
        }
    }
}