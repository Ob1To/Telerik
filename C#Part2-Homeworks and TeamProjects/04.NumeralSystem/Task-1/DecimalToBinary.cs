/*Write a program to convert decimal numbers to their binary representation.*/


using System;
using System.Collections.Generic;

namespace Task_1
{
    class DecimalToBinary
    {
        static List<int> ConvertDecinalToBinary (int number)
        {
            List<int> binaryList = new List<int>();
            while (number > 0)
            {
                int leftOver = 0;
                leftOver = number % 2;
                binaryList.Add(leftOver);
                number /= 2;
            }
            binaryList.Reverse();
            return binaryList;
        }
        static void Main()
        {
            Console.WriteLine("Please enter your decimal number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Your binary representation is: ");
            Console.WriteLine(string.Join("", ConvertDecinalToBinary(number)));

        }
    }
}
