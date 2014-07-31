namespace Task_2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;
    public static class IEnumerableExtension
    {
        public static double sum<T>(this IEnumerable<T> collection)
        {
            double sum = 0;
            foreach (var number in collection)
            {
                sum += Convert.ToDouble(number);
            }
            return sum;
        }

        public static double Product<T>(this IEnumerable<T> collection)
        {
            double sum = 1;
            foreach (var number in collection)
            {
                sum *= Convert.ToDouble(number);
            }
            return sum; ;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T Max = collection.ElementAt(0);

            foreach (T number in collection)
            {
                if (number.CompareTo(Max) > 0)
                {
                    Max = number;
                }
            }
            return Max;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T Min = collection.ElementAt(0);

            foreach (T number in collection)
            {
                if (number.CompareTo(Min) < 0)
                {
                    Min = number;
                }
            }
            return Min;
        }
        public static double Avg<T>(this IEnumerable<T> collection)
        {
            return collection.sum<T>() / collection.Count<T>();
        }
    }
}
