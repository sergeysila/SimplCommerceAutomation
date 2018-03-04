using System;
using System.Collections.Generic;
using System.Linq;

namespace Automation.Common.Helpers.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var x in enumerable)
            {
                action(x);
            }
        }
        
        public static IEnumerable<T> Add<T>(this IEnumerable<T> enumerable, params T[] items)
        {
            return enumerable.Concat(items);
        }
    }
}