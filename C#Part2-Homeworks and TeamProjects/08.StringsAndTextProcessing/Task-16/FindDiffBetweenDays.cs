/* Write a program that reads two dates in the format: 
 * day.month.year and calculates the number of days between them. 
 * Example:
 * 
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days
 */

namespace Task_16
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class FindDiffBetweenDays
    {
        static void Main()
        {
            Console.WriteLine("Please enter first date in the format dd.mm.yyyy: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second date in the format dd.mm.yyyy: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan diff = secondDate.Subtract(firstDate);
            Console.WriteLine("The difference between the 2 dates is {0} days", diff.Days);
        }
    }
}
