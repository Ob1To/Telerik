//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


namespace Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class IsLeapYear
    {
        static void Main()
        {
            Console.WriteLine("Please enter a year to check if its leap or not: ");
            int leapYear = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(leapYear))
            {
                Console.WriteLine("The year {0} is leap!", leapYear);
            }
            else
            {
                Console.WriteLine("The year {0} is not leap!", leapYear);
            }
        }
    }
}
