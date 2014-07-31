//Write a program that prints to the console which day of the week is today. Use System.DateTime.


using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class WhichDayIsToday
    {
        static void Main()
        {
            DateTime day = DateTime.Today;
            Console.WriteLine("Today is {0}",day.DayOfWeek);
        }
    }
}
