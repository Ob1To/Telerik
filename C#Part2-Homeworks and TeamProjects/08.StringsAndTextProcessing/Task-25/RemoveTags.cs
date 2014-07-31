/* 
 * Write a program that extracts from given HTML 
 * file its title (if available), and its body 
 * text without the HTML tags. Example:
 * 
 *  <html>
    <head><title>News</title></head>
    <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
    </html>

 */

namespace Task_25
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class RemoveTags
    {
        static void Main()
        {
            string text = string.Empty;
            StreamReader reader = new StreamReader("../../html.txt");
            using (reader)
            {
                text = reader.ReadToEnd();
            }
            int startIndex = text.IndexOf('<');
            int endIndex = text.IndexOf('>');

            while (startIndex >= 0)
            {
                text = text.Remove(startIndex, endIndex - startIndex + 1);

                startIndex = text.IndexOf('<');
                endIndex = text.IndexOf('>');
            }
            text = text.Trim();
            Console.WriteLine(text);
        }
    }
}
