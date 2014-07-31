/* Write a program that converts a string to a sequence of C# 
 * Unicode character literals. Use format strings. 
 * Sample input:

 * Hi!

 * Expected output:
 * \u0048\u0069\u0021

 */

namespace Task_10
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class StringToUnicodeCharacterLiterals
    {
        static void ConvertToUnicodeCharacterLiterals(string str)
        {
            foreach (var symbol in str)
            {
                int charSymbol = symbol;
                Console.Write("\\u{0:x4}", charSymbol);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            ConvertToUnicodeCharacterLiterals(str);

        }
    }
}
