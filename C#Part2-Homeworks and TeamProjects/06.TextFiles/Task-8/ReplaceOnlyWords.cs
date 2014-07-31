/* 
 * Modify the solution of the previous problem 
 * to replace only whole words (not substrings).
 */

namespace Task_8
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Text.RegularExpressions; // Here i'm using regular expressions . More information here : http://www.codeproject.com/Articles/9099/The-30-Minute-Regex-Tutorial
    class ReplaceOnlyWords
    {
        static void Main()
        {
            string[] diffWords = { " hahahaStart", " Startfail", "\r\n", " optimum", " interesting",  "mixstartmixmix", "start"};
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
                        lines = lines.ToLower();
                        writer.WriteLine(Regex.Replace(lines, @"\bstart\b", "finish")); // replace start if it is only a whole word
                        lines = reader.ReadLine();
                    }
                }
            }
        }
    }
}
