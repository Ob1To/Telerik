/* 
 * Write a program that reads a string from the 
 * console and lists all different words in the 
 * string along with information how many times each word is found.
 */

namespace Task_22
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class HowManyWords
    {
        static void Main()
        {
            Console.WriteLine("Please enter some text: ");
            string text = Console.ReadLine();
            string[] separators = { " ", ",", ".", "!", "?" };
            string[] allWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> information = new Dictionary<string, int>();

            foreach (var word in allWords)
            {
                if (information.ContainsKey(word))
                {
                    information[word]++;
                }
                else
                {
                    information.Add(word, 1);
                }
            }

            foreach (var word in information)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }
        }
    }
}
