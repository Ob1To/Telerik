/* Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:

We are living in an yellow submarine. 
 * We don't have anything else. 
 * Inside the submarine is very tight. 
 * So we are drinking all the day. We will move out of it in 5 days.

	The result is: 9.
 */

namespace Task_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class SubstringContaining
    {
        static void HowManySubstrings(string text)
        {
            string searchFor = "in";
            int repeated = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i,searchFor.Length).ToLower() == searchFor)
                {
                    repeated++;
                    i += (searchFor.Length - 1);
                }
            }
            Console.WriteLine("The text your are searching from is: \n");
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Your substring is found {0} times in the string",repeated);
        }
        static void Main()
        {
            string text = ("We are living in an yellow submarine. \nWe don't have anything else. Inside the submarine is very tight. \nSo we are drinking all the day. \nWe will move out of it in 5 days.");
            HowManySubstrings(text);
        }
    }
}
