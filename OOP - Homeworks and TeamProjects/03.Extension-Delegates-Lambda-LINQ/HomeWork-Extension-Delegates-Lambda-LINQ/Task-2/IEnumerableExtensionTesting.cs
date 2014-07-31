/*
 * Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average.
 */

namespace Task_2
{
    using System;
    using System.Collections.Generic;
    public class IEnumerableExtensionTesting
    {
        static void Main()
        {
            List<double> testing = new List<double>();
            testing.Add(4.3);
            testing.Add(5.2);
            testing.Add(1.3);
            testing.Add(7.4);

            Console.WriteLine("Sum = {0}",testing.sum());
            Console.WriteLine("Min: {0}", testing.Min());
            Console.WriteLine("Max: {0}", testing.Max());
            Console.WriteLine("Product: {0}", testing.Product());
            Console.WriteLine("Avg: {0}", testing.Avg());
        }
    }
}
