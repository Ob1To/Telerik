namespace Task_17
{
    using System;
    using System.Linq;
    public class MaxLengthString
    {

        public static string FindMaxLengthString(string[] array)
        {
            var longestString = array.OrderByDescending(x => x.Length);
            return longestString.ElementAt(0);
        }
        static void Main()
        {
            string[] test = { "22", "12345", "I'm The longest string", "test" };
            Console.WriteLine(FindMaxLengthString(test));
        }
    }
}
