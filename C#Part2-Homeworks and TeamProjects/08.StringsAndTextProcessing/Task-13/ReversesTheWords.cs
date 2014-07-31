/* Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!"  
 * "Delphi not and PHP, not C++ not is C#!".
 */

namespace Task_13
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class ReversesTheWords
    {
        static void Main()
        {
            string sSentence = "C# is not C++, not PHP and not Delphi!";
            string[] asWordsAndSymbols = sSentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] asCleanWords = sSentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(asCleanWords);
            string sTemp1 = null, sTemp2 = null;
            for (int i = 0; i < asWordsAndSymbols.Length; i++)
            {
                if (string.Equals(asWordsAndSymbols[i], asCleanWords[asWordsAndSymbols.Length - i - 1]))
                {
                    Console.Write(asCleanWords[i] + " ");
                }
                else
                {
                    sTemp1 = asCleanWords[asWordsAndSymbols.Length - i - 1];
                    sTemp2 = asWordsAndSymbols[i];
                    Console.Write(asCleanWords[i] + sTemp2.Replace(sTemp1, "") + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
