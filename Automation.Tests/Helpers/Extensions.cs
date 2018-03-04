using System;
using System.Collections.Generic;
using System.Linq;

namespace Automation.Tests.Helpers
{
    public static class Extensions
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

        public static string RemoveControlCharacters(this string inText)
            => inText
                .Replace("\0", "")
                .Replace("\a", "")
                .Replace("\b", "")
                .Replace("\t", "")
                .Replace("\f", "")
                .Replace("\n", "")
                .Replace("\r", "");
    }
}