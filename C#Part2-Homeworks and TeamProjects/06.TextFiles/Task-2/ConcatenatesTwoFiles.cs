/* Write a program that concatenates two text files into another text file. */

namespace Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class ConcatenatesTwoFiles
    {
        static void Main()
        {
            StreamReader readFirst = new StreamReader(@"..\..\..\files\Text1.txt");
            StreamReader readSecond = new StreamReader(@"..\..\..\files\Text2.txt");
            StreamWriter writer = new StreamWriter(@"..\..\..\files\concatenated.txt");

            using (readFirst)
            {
                using (readSecond)
                {
                    using (writer)
                    {
                        string firstText = readFirst.ReadToEnd();
                        string secondText = readSecond.ReadToEnd();
                        writer.Write(firstText + "\r\n" + secondText);
                    }
                }
            }
            Console.WriteLine("DONE! Search and read your new file in the folder \"files\"");
        }
    }
}
