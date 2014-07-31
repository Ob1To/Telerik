/* 
 * Write a program that reads a string from the 
 * console and prints all different letters in the 
 * string along with information how many times each letter is found. 
 */

namespace Task_21
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class HowManyLetters
    {
        static void Main()
        {
            Console.WriteLine("Please insert a string: ");
            string text = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (var symbol in text.ToLower())
            {
                if (char.IsLetter(symbol))
                {
                    if (letters.ContainsKey(symbol))
                    {
                        letters[symbol]++;
                    }
                    else
                    {
                        letters.Add(symbol, 1);
                    }
                }
            }
            foreach (var letter in letters)
            {
                Console.WriteLine("{0} - {1,5} times found",letter.Key,letter.Value);
            }
            Console.WriteLine();
        }
    }
}
