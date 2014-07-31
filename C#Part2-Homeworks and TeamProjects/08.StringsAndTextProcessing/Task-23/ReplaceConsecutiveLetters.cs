/* 
 * Write a program that reads a string from the console 
 * and replaces all series of consecutive identical letters 
 * with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
 */

namespace Task_23
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class ReplaceConsecutiveLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            StringBuilder letterByLetter = new StringBuilder();

            letterByLetter.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != letterByLetter[letterByLetter.Length - 1])
                {
                    letterByLetter.Append(text[i]);
                }
            }
            letterByLetter.ToString();
            Console.WriteLine(letterByLetter);
        }
    }
}
