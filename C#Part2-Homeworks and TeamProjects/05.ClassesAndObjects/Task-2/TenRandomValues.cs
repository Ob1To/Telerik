//Write a program that generates and prints to the console 10 random values in the range [100, 200].


namespace Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class TenRandomValues
    {
        static Random rnd = new Random();
        static void Main()
        {
            for (int i = 1; i < 11; i++)
            {
                int tempRandomNumber = rnd.Next(100,200);
                Console.WriteLine("Your {0} random number is: {1}",i,tempRandomNumber);
            }
        }
    }
}
