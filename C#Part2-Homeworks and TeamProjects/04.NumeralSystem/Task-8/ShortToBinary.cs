//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    public static long ConvertDecimalToBin(short number)
    {
        long result = 0;
        long power = 1;
        if (number < 0)
        {
            result = 1111111111111111;
            number += 1;
        }

        while (number != 0)
        {
            result += (number % 2) * power;
            number /= 2;
            power *= 10;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number to convert to binary:");
        short numberInDecimal = short.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToBin(numberInDecimal));
    }
}
