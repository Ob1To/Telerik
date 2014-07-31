/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
*/

using System;
using System.Collections.Generic;


namespace Task_13
{
    class SolveTask
    {
        static void ReverseDigits()
        {
            int number = int.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.WriteLine("Number should not be negative");
                number = int.Parse(Console.ReadLine());
            }
            int reverseNumber = 0;
            while (number > 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);
                number /= 10;
            }
            Console.WriteLine(reverseNumber);
        }
        static void CalculatesSequenceOfIntegers()
        {
            Console.WriteLine("Input of how long  sequence you want to find avarage");
            int numberN = int.Parse(Console.ReadLine());
            while (numberN <= 0)
            {
                Console.WriteLine("The sequence must be bigger then zero");
                numberN = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input integer number for where your sequence start is");
            int numberStart = int.Parse(Console.ReadLine());
            int numberAvarage = 0;
            for (int caunt = numberStart; caunt <= numberStart + numberN - 1; caunt++)
            {
                numberAvarage += caunt;
            }
            Console.WriteLine("The avarage of this sequence of integer numbers is {0}", numberAvarage / numberN);
        }
        static void SolvesLinearEquation()
        {
            Console.WriteLine("Input number for argument a");
            int numberA = int.Parse(Console.ReadLine());
            while (numberA == 0)
            {
                Console.WriteLine("a can't be zero");
                numberA = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input number for argument b");
            int numberB = int.Parse(Console.ReadLine());
            Console.WriteLine(-(double)numberB / numberA);
        }
        static void Main()
        {
            Console.WriteLine("Choose what do you want to do : ");
            Console.WriteLine("Press 1 (one) if you want to reverse digits of an number");
            Console.WriteLine("Press 2 (two) if you want to calculates average of a sequence of integers");
            Console.WriteLine("Press 3 (three) if you want to solves a linear equation");
            int numberN = int.Parse(Console.ReadLine());
            while (numberN > 3 || numberN < 0)
            {
                Console.WriteLine("Invalid Selection");
                numberN = int.Parse(Console.ReadLine());
            }

            switch (numberN)
            {
                case 1: ReverseDigits();
                    break;
                case 2: CalculatesSequenceOfIntegers();
                    break;
                case 3: SolvesLinearEquation();
                    break;
            }
        }
    }
}
