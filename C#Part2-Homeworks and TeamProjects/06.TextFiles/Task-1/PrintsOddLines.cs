/* Write a program that reads a text file and prints on the console its odd lines. */

namespace Task_1
{
    using System;
    using System.IO;
    class PrintsOddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\Text1.txt");
            int counterForOddLines = 0;
            string text = reader.ReadLine();
            while (text != null)
            {
                if (counterForOddLines % 2 == 0)
                {
                    Console.WriteLine(text);
                    text = reader.ReadLine();
                    counterForOddLines++;
                }
                else
                {
                    counterForOddLines++;
                    text = reader.ReadLine();
                }
            }
            reader.Close();
        }
    }
}
