/*Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
using System.Text;

namespace Task_3
{
    class DecimalToHexa
    {

        static char[] Convertor (int number)
        {

            StringBuilder yourNumber = new StringBuilder();
            int leftOver = 0;
            while (number > 0)
            {
                leftOver = number % 16;
                    switch (leftOver)
                    {
                        case 10: yourNumber.Append('A'); break;
                        case 11: yourNumber.Append('B'); break;
                        case 12: yourNumber.Append('C'); break;
                        case 13: yourNumber.Append('D'); break;
                        case 14: yourNumber.Append('E'); break;
                        case 15: yourNumber.Append('F'); break;
                        default: yourNumber.Append(leftOver); break; 
                    }
                number /= 16;
            }
            char[] myNumber = new char[yourNumber.Length];
            for (int i = 0, j = yourNumber.Length - 1; i < yourNumber.Length; i++, j--)
            {
                myNumber[i] = yourNumber[j]; //reversing the array to get the correct result when converting
            }
            return myNumber;
        }
        static void Main()
        {
            Console.WriteLine("Please enter your decimal number: ");
            int numberInDecimal = int.Parse(Console.ReadLine());
            Console.Write("Your number in hexadesimal is : ");
            Console.WriteLine(string.Join("", Convertor(numberInDecimal)));
        }
    }
}
