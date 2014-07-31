/* You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. 
 * Example:string = "43 68 9 23 318"  result = 461 */

namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class CalcStringSums
    {
        static int SumOfStrings(string number)
        {
            int theSum = 0;
            string[] numersInArray = number.Split(' ');
            for (int i = 0; i < numersInArray.Length; i++)
            {
                theSum += int.Parse(numersInArray[i]);
            }
            return theSum;
        }
        static void Main()
        {
            Console.WriteLine("Please enter a string of numbers and spaces that you want to sum");
            string number = Console.ReadLine();
            Console.WriteLine("The sum of your numbers is: {0}", SumOfStrings(number));
        }
    }
}
