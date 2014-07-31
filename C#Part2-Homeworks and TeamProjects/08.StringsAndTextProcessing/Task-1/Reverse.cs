/* Write a program that reads a string, 
 * reverses it and prints the result at the console.
Example: "sample"  "elpmas".
 */

namespace Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Reverse
    {
        static void ReverseString(string str)
        {
            char[] wordToCharArray = str.ToCharArray();
            Array.Reverse(wordToCharArray);
            Console.WriteLine(wordToCharArray);
        }
        static void Main()
        {
            Console.WriteLine("Please enter a string to reverse: ");
            string str = Console.ReadLine();
            ReverseString(str);
        }
    }
}
