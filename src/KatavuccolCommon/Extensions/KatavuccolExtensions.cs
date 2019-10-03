using System;
using System.Collections.Generic;
using System.Linq;

namespace KatavuccolCommon.Extensions
{
    public static class KatavuccolExtensions
    {
        public static bool AnyWithNullCheck<TSource>(this IEnumerable<TSource> value)
        {
            if (value == null)
                return false;
            return value.Any();
        }

        public static bool IsEmpty(this object value)
        {
            return value == null;
        }

        public static bool IsEmpty(this string value)
        {
            if (value == null)
                return true;
            return string.IsNullOrWhiteSpace(value);
        }

        public static long ToLong(this string value)
        {
            if (value.IsEmpty())
                return 0;
            if (long.TryParse(value, out long result))
                return result;
            return 0;
        }

        public static bool IsEqual(this string value,string another)
        {
           return string.Equals(value,another,StringComparison.InvariantCultureIgnoreCase);
        }
    }
}