/* You are given a text. Write a program that changes the text 
 * in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
 * The tags cannot be nested. 
 * Example:
 * 
We are living in a <upcase>yellow submarine</upcase>. 
 * We don't have <upcase>anything</upcase> else.
 * 
		The expected result:
 * We are living in a YELLOW SUBMARINE. 
 * We don't have ANYTHING else.
 */

namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class UpperText
    {
        static void UpCaseSurrounded(string text)
        {
            int startIndex = 0;
            int endIndex = 0;
            string upCase = ("<upcase>");
            string endCase = ("</upcase>");
            for (int i = 0; i < text.Length - 8; i++)
            {
                if (text.Substring(i,upCase.Length) == upCase)
                {
                    startIndex = i;
                }
                if (text.Substring(i, endCase.Length) == endCase)
                {
                    endIndex = i + endCase.Length;
                    string replace = text.Substring(startIndex, endIndex - startIndex);
                    string temp = text.Substring(startIndex + upCase.Length,(endIndex-endCase.Length)- (startIndex + upCase.Length)).ToUpper();
                    text = text.Replace(replace,temp);
                }
            }
            Console.WriteLine(text);
        }
        static void Main()
        {
            string text = ("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.");
            UpCaseSurrounded(text);
        }
    }
}
