/* Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the 
 * characters should be filled with '*'. 
 * Print the result string into the console.
 */

namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class PrintStarsToTheEnd
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string");
            string text = Console.ReadLine();

            if (text.Length < 20)
            {
                for (int i = text.Length; i < 20; i++)
                {
                    text += '*';
                }
            }
            Console.WriteLine(text);
        }
    }
}
