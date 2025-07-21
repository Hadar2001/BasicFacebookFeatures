using System;
using System.Collections.Generic;
using System.Reflection;

namespace BasicFacebookFeatures
{
    internal class SortStrategyByDateTimeField<T> : ISortStrategy<T>
    {
        public string StrategyTitle => $"Sort By {FieldName}";
        
        public string StrategyName { get; }
        
        public string FieldName { get; }

        public SortStrategyByDateTimeField(string i_StrategyName, string i_FieldName)
        {
            StrategyName = i_StrategyName;
            FieldName = i_FieldName;
        }

        public void Sort(List<T> i_Items, string i_FieldName)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(i_FieldName);
            DateTime secondItemDate;
            DateTime firstItemDate;

            if (propertyInfo == null)
            {
                throw new ArgumentException($"Field '{i_FieldName}' does not exist on type '{typeof(T).Name}'.");
            }

            if (propertyInfo.PropertyType != typeof(DateTime) && propertyInfo.PropertyType != typeof(DateTime?))
            {
                throw new ArgumentException($"Field '{i_FieldName}' must be of type DateTime or Nullable<DateTime>.");
            }

            i_Items.Sort((x, y) =>
            {
                firstItemDate = (DateTime?)propertyInfo.GetValue(x) ?? DateTime.MinValue;
                secondItemDate = (DateTime?)propertyInfo.GetValue(y) ?? DateTime.MinValue;

                return firstItemDate.CompareTo(secondItemDate);
            });
        }
    }
}
