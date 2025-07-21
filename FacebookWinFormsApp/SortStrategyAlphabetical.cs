using System;
using System.Collections.Generic;
using System.Reflection;
using BasicFacebookFeatures;

public class SortStrategyAlphabetical<T> : ISortStrategy<T>
{
    public string StrategyName { get; }

    public string FieldName { get; }

    public string StrategyTitle => "Alphabetical Sort";

    public SortStrategyAlphabetical(string i_StrategyName, string i_FieldName)
    {
        StrategyName = i_StrategyName;
        FieldName = i_FieldName;
    }

    public void Sort(List<T> i_Items, string i_FieldName)
    {
        PropertyInfo propertyInfo = typeof(T).GetProperty(i_FieldName);

        if (propertyInfo == null)
        {
            throw new ArgumentException($"Field '{i_FieldName}' does not exist on type '{typeof(T).Name}'.");
        }

        i_Items.Sort((x, y) =>
        {
            string valX = propertyInfo.GetValue(x)?.ToString();
            string valY = propertyInfo.GetValue(y)?.ToString();

            return string.Compare(valX, valY, StringComparison.OrdinalIgnoreCase);
        });
    }
}

