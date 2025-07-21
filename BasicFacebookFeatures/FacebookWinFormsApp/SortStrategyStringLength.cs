using System;
using System.Collections.Generic;
using System.Reflection;

namespace BasicFacebookFeatures
{
    internal class SortStrategyStringLength<T> : ISortStrategy<T>
    {
        public string StrategyTitle => "Sort By Length";

        public string StrategyName { get; }

        public string FieldName { get; }

        public SortStrategyStringLength(string i_StrategyName, string i_FieldName)
        {
            FieldName = i_FieldName;
            StrategyName = i_StrategyName;
        }

        public void Sort(List<T> i_Items, string i_FieldName)
        {
            int stringOneLength;
            int stringTwoLength;
            PropertyInfo propertyInfo;

            propertyInfo = typeof(T).GetProperty(i_FieldName);

            if (propertyInfo == null)
            {
                throw new ArgumentException($"Field '{i_FieldName}' does not exist on type '{typeof(T).Name}'.");
            }

            i_Items.Sort((item1, item2) =>
            {
                stringOneLength = (propertyInfo.GetValue(item1, null) as string)?.Length ?? 0;
                stringTwoLength = (propertyInfo.GetValue(item2, null) as string)?.Length ?? 0;

                return stringTwoLength.CompareTo(stringOneLength);
            });
        }
    }
}
