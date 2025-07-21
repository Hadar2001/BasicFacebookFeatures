using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public interface ISortStrategy<T>
    {
        string StrategyName { get; }

        string StrategyTitle { get; }

        string FieldName { get; }

        void Sort(List<T> i_Items, string i_FieldName);
    }
}