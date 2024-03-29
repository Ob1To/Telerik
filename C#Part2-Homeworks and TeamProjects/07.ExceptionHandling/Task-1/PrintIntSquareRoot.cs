﻿/* Write a program that reads an integer number and calculates and 
 * prints its square root. If the number is invalid or negative, 
 * print "Invalid number". In all cases finally print "Good bye". 
 * Use try-catch-finally.
 */

namespace Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class PrintIntSquareRoot
    {
        static void Main()
        {
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
