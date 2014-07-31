/*
 * Write a program that prints from given array of integers 
 * all numbers that are divisible by 7 and 3. Use the 
 * built-in extension methods and lambda expressions. 
 * Rewrite the same with LINQ.
 */


namespace Task_6
{
    using System;
    using System.Linq;
    using Task_3;
    class DivisibleBy3And7
    {
        // public static Random random = new Random();

        static void Main()
        {
            int[] numbers = new int[100];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            var allDivisible = numbers.Where(num => num % 7 == 0 && num % 3 == 0);

            Console.WriteLine("This is with lambda:\n");

            Task_3.FirstNameBeforeLastTest.Print(allDivisible);

            Console.WriteLine();

            Console.WriteLine("And now without:\n");

            var allDivisibleLINQ = from number in numbers where number % 7 == 0 && number % 3 == 0 select number;

            Task_3.FirstNameBeforeLastTest.Print(allDivisibleLINQ);
        }
    }
}
