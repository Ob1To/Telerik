/*Write a program to convert from any numeral system of given 
 * base s to any other numeral system of 
 * base d (2 ≤ s, d ≤  16).*/

namespace Task_7
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class FromAnyNumeralSystem
    {
        static string ConvertToUserChoice(int numberInDecimal, int theBaseWeNeedToConvert)
        {
            StringBuilder convertedNumber = new StringBuilder();
            int leftOver = 0;
            while (numberInDecimal > 0)
            {
                leftOver = numberInDecimal % theBaseWeNeedToConvert;
                switch (leftOver)
                {
                    case 10: convertedNumber.Insert(0,('A')); break;
                    case 11: convertedNumber.Insert(0, ('B')); break;
                    case 12: convertedNumber.Insert(0, ('C')); break;
                    case 13: convertedNumber.Insert(0, ('D')); break;
                    case 14: convertedNumber.Insert(0, ('E')); break;
                    case 15: convertedNumber.Insert(0, ('F')); break;
                    default: convertedNumber.Insert(0,leftOver); break;
                }
                numberInDecimal /= theBaseWeNeedToConvert;
            }
            return convertedNumber.ToString();
        }
        static int ConvertToDecimal(int firstBase, string number)
        {
            int numberInDecimal = 0;
            for (int i = 0,j = number.Length - 1; i < number.Length; i++, j--)
            {
                switch (number[i])
                {
                    case 'A': numberInDecimal += 10 * (int)Math.Pow(firstBase, j); break;
                    case 'B': numberInDecimal += 11 * (int)Math.Pow(firstBase, j); break;
                    case 'C': numberInDecimal += 12 * (int)Math.Pow(firstBase, j); break;
                    case 'D': numberInDecimal += 13 * (int)Math.Pow(firstBase, j); break;
                    case 'E': numberInDecimal += 14 * (int)Math.Pow(firstBase, j); break;
                    case 'F': numberInDecimal += 15 * (int)Math.Pow(firstBase, j); break;
                    default: numberInDecimal += (number[i] - '0') * (int)Math.Pow(firstBase, j); break;
                }
            }
            return numberInDecimal;
        }
        static void Main()
        {
            Console.WriteLine("Please enter the first base of the numeral system you want to use (number must be between 2 and 16) : ");
            int firstBase = int.Parse(Console.ReadLine());
            while (firstBase >= 17 && firstBase < 2)
            {
                Console.Write("Error !!! Please enter valid number between 2 and 16");
                firstBase = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the second base of the numeral system you want to use (number must be between 2 and 16) : ");
            int secondBase = int.Parse(Console.ReadLine());
            while (secondBase >= 17 && secondBase < 2)
            {
                Console.Write("Error !!! Please enter valid number between 2 and 16");
                secondBase = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Now Please enter the number you want to convert from one base to another: ");
            string numberToConvert = Console.ReadLine();
            Console.WriteLine("Your number {0} converted from \"{1}\" to \"{2}\" base system is: {3}",numberToConvert, firstBase, secondBase,ConvertToUserChoice(ConvertToDecimal(firstBase,numberToConvert),(secondBase)));
        }
    }
}
