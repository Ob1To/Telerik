/*
 * Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Text;


namespace Task_4
{
    class HexadecimalToDecimal
    {
        static int convertor(string hexaNumber)
        {
            int deciNumber = 0;
            for (int i = hexaNumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                switch (hexaNumber[j])
                {
                    case 'A': deciNumber += 10 * (int)Math.Pow(16, i); break;
                    case 'B': deciNumber += 11 * (int)Math.Pow(16, i); break;
                    case 'C': deciNumber += 12 * (int)Math.Pow(16, i); break;
                    case 'D': deciNumber += 13 * (int)Math.Pow(16, i); break;
                    case 'E': deciNumber += 14 * (int)Math.Pow(16, i); break;
                    case 'F': deciNumber += 15 * (int)Math.Pow(16, i); break;
                    default: deciNumber += (hexaNumber[j] - '0') * (int)Math.Pow(16, i); break;
                }
            }
            return deciNumber;
        }
        static void Main()
        {
            Console.WriteLine("Please enter your hexadecimal number to convert: ");
            string hexaNumber = Console.ReadLine();
            hexaNumber = hexaNumber.ToUpper(); //convert small letters to big if there are some inputed by mistake or something
            Console.WriteLine("Your result from converting is : {0}",convertor(hexaNumber));

        }
    }
}
