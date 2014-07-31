/* 
 * Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file.
 */

namespace Task_9
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class DeleteOddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\Task9.txt");
            using (reader)
            {
                string checkPreActio = reader.ReadToEnd();
                Console.WriteLine("The file before the action looks like this");
                Console.WriteLine();
                Console.WriteLine(checkPreActio);
            }
            reader = new StreamReader(@"..\..\..\files\Task9.txt");
            List<string> allLines = new List<string>();
            int counterForOdd = 1;
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counterForOdd % 2 == 0)
                    {
                        allLines.Add(line);
                    }
                    counterForOdd++;
                    line = reader.ReadLine();
                }
            }
            StreamWriter writer = new StreamWriter(@"..\..\..\files\Task9.txt", false);
            using (writer)
            {
                for (int i = 0; i < allLines.Count; i++)
                {
                    writer.WriteLine(allLines[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Operation Complete ! Now the file looks like this ->");
            reader = new StreamReader(@"..\..\..\files\Task9.txt");
            using (reader)
            {
                string checkPreActio = reader.ReadToEnd();
                Console.WriteLine();
                Console.WriteLine(checkPreActio);
            }
        }
    }
}
