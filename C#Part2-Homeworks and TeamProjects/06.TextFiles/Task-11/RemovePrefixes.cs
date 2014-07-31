/* Write a program that deletes from a text file all words 
 * that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.
 */

namespace Task_11
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Text.RegularExpressions;
    class RemovePrefixes
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\Task11Source.txt");
            StreamWriter writer = new StreamWriter(@"..\..\..\files\Task11WithoutPrefixX.txt");
            string line = reader.ReadLine();

            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        string lineWithoutTest = Regex.Replace(line, @"\btest\w*\b", String.Empty);
                        writer.WriteLine(lineWithoutTest);
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}
