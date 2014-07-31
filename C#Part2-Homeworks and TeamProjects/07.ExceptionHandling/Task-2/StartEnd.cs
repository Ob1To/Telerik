/* Write a method ReadNumber(int start, int end) that enters an integer number 
 * in given range [start…end]. 
 * If an invalid number or non-number text is entered, 
 * the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

namespace Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class StartEnd
    {
        static void ReadNumber(int start, int end)
        {
           
          int[] allNumbers = new int[10];
          for (int i = 0; i < 10; i++)
          {
              try
              {
                  allNumbers[i] = int.Parse(Console.ReadLine());
                  if (allNumbers[i] < start || allNumbers[i] > end)
                  {
                      throw new ArgumentOutOfRangeException();
                  }
              }
              catch (FormatException)
              {
                  Console.WriteLine("Invalid format of input!"); 
                  break;
              }
              catch (ArgumentOutOfRangeException)
              {
                  Console.WriteLine("The number is out of the range!"); 
                  break;
              }
              start = allNumbers[i]; // because in the tast is said that a1, a2, … a10, such that 1 < a1 < … < a10 < 100 !
          }
        }
        static void Main()
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }
    }
}
