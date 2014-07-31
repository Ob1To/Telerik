/* Write a program that replaces all occurrences of the 
 * substring "start" with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).
 */

namespace Task_7
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class ReplaceString
    {
        static void Main()
        {
            string[] diffWords = { " hahaha", " fail","\r\n", " optimum", " start", " hahastart" };
            Random randomWords = new Random();
            StreamWriter writer = new StreamWriter(@"..\..\..\files\RandomWordsList.txt");
            using (writer)
            {
                for (int i = 0; i < 250; i++)
                {
                    writer.Write(diffWords[randomWords.Next(diffWords.Length)]); //Create uniques text files every time with the words from the array above
                }
            }
            writer = new StreamWriter(@"..\..\..\files\Task7Result.txt");
            StreamReader reader = new StreamReader(@"..\..\..\files\RandomWordsList.txt");

            string lines = reader.ReadLine();
            using (writer)
            {
                using (reader)
                {
                    while (lines != null)
                    {
                        writer.WriteLine(lines.Replace("start", "finish"));
                        lines = reader.ReadLine();
                    }
                }
            }
        }
    }
}
