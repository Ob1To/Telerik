/* Write a program that reads a text file and inserts line 
 * numbers in front of each of its lines. 
 * The result should be written to another text file.
 */

namespace Task_3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\Text1.txt");
            using (reader)
            {
                int counter = 1;
                string theLine = reader.ReadLine();
                StreamWriter writer = new StreamWriter(@"..\..\..\files\WithLines.txt");
                using (writer)
                {
                    while (theLine != null)
                    {
                        writer.Write("Line {0} : ", counter);
                        writer.WriteLine(theLine);
                        theLine = reader.ReadLine();
                        counter++;
                    }
                }
            }
            StreamReader readNew = new StreamReader(@"..\..\..\files\WithLines.txt");
            string checkResult = readNew.ReadToEnd();
            Console.WriteLine(checkResult);
        }
    }
}
