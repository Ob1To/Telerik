/* 
 * Write a program that extracts from a given 
 * text all palindromes, e.g. "ABBA", "lamal", "exe". 
 */

namespace Task_20
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class ExtractAllPalindromes
    {
        static void Main()
        {
            string str = "ABBA ffeerer efffefee, lamal ererfe exeff exe ";
            string[] separators = { " ", ",", ".", "!", "?" };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder palindromes = new StringBuilder();
            bool thereAreSome = false;
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                string reversed = new string(word);
                if (reversed == words[i])
                {
                    palindromes.Append(words[i]).Append(" ");
                    thereAreSome = true;
                }
            }
            palindromes.ToString();
            if (thereAreSome)
            {
                Console.WriteLine("Your palindromes are: {0}", palindromes);
            }
            else
            {
                Console.WriteLine("There are no palindromes");
            }
        }
    }
}
