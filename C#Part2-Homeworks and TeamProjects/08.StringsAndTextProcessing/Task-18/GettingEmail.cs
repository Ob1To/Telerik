/* 
 * Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> 
 * should be recognized as emails.
 */

namespace Task_18
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    class GettingEmail
    {
        static void Main()
        {
            string inputText = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string pattern = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b";
            List<string> resultList = new List<string>();
            Match regex = Regex.Match(inputText, pattern, RegexOptions.IgnoreCase);

            while (true)
            {
                if (regex.Success)
                {
                    string result = regex.Value;
                    resultList.Add(result);
                }
                else
                {
                    break;
                }
                regex = regex.NextMatch();
            }

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
