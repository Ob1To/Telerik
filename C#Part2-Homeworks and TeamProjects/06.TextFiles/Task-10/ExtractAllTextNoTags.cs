/* Write a program that extracts from given XML file all the text without the tags.
 */

namespace Task_10
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class ExtractAllTextNoTags
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\Task10Source.txt");
            string text = reader.ReadToEnd();
            int begin = text.IndexOf('<');
            int end = text.IndexOf('>');
            while (begin >= 0)
            {
                text = text.Remove(begin, end - begin +1);
                   
                begin = text.IndexOf('<');
                end = text.IndexOf('>');
            }
 
            text = text.Trim();
            Console.WriteLine(text);
        }
    }
}
