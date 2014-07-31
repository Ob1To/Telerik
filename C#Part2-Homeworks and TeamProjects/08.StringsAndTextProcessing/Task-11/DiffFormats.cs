/* 
 * Write a program that reads a number and prints it
 * as a decimal number, hexadecimal number, 
 * percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols. 
 */

namespace Task_11
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class DiffFormats
    {
        static void PrintingNumbersInDiffFormats(int number)
        {
            Console.WriteLine("Decimal number is: {0,15}",number);
            Console.WriteLine("Hexadecimal number is: {0,15:X4}",number);
            Console.WriteLine("Percentage: {0,15:P}", number);
            Console.WriteLine("Scientific: {0,15:E}", number);
        }
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            PrintingNumbersInDiffFormats(number);
        }
    }
}
