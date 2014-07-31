/* 
 * Write a program that reads a list of words, 
 * separated by spaces and prints the list in an alphabetical order.
 */

namespace Task_24
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class SortWords
    {
        static void Main()
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            string[] separators = { " ", ",", ".", "!", "?" };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
