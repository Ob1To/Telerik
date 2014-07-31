/*Write a method that calculates the number of workdays between today and given date, 
 * passed as parameter. Consider that workdays are all days from Monday to Friday except a 
 * fixed list of public holidays specified preliminary as array.*/


namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class NumberOfWorkDays
    {

        static int WorkDays(DateTime today, DateTime endDay, DateTime[] holidays)
        {
            DayOfWeek Saturday = DayOfWeek.Saturday;
            DayOfWeek Sunday = DayOfWeek.Sunday;
            int counter = (endDay - today).Days;
            while (endDay > today)
            {
                if (today.DayOfWeek == Saturday || today.DayOfWeek == Sunday)
                {
                    counter--;
                }
                else
                {
                    foreach (var day in holidays)
                    {
                        if (today == day)
                        {
                            counter--;
                        }
                    }
                }
                today = today.AddDays(1);
            }
            return counter;
        }
        static void Main()
        {
            DateTime currentDate = DateTime.Today;

            Console.WriteLine("Please enter the date of your end day check like that: <YYYY-MM-DD> ");
            DateTime endDay = DateTime.Parse(Console.ReadLine());

            DateTime[] holidays = { new DateTime(2014, 01, 01), new DateTime(2014, 03, 03), new DateTime(2014, 05, 01), new DateTime(2014, 05, 06), new DateTime(2014, 05, 24), new DateTime(2014, 09, 06), new DateTime(2014, 09, 22), new DateTime(2014, 11, 01), new DateTime(2014, 12, 24), new DateTime(2014, 01, 26), new DateTime(2014, 12, 25), };

            Console.WriteLine("Your number of workdays during this period are: {0}", WorkDays(currentDate,endDay,holidays));
        }
    }
}
