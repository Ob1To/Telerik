/* Write a program that compares two text files line by line and prints the number of 
 * lines that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines.
 */

namespace Task_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class CompareTwoFiles
    {
        static void Main()
        {
            StreamReader reader1 = new StreamReader(@"..\..\..\files\Text1.txt");
            StreamReader reader2 = new StreamReader(@"..\..\..\files\Text1alt.txt");
            string text1 = reader1.ReadLine();
            string text2 = reader2.ReadLine();
            int sameLines = 0;
            int diffLines = 0;
            using (reader1)
            using (reader2)
            {
                while (text1 != null && text2 != null)
                {
                    if (text1.CompareTo(text2) == 0)
                    {
                        sameLines++;
                        text1 = reader1.ReadLine();
                        text2 = reader2.ReadLine();
                    }
                    else
                    {
                        diffLines++;
                        text1 = reader1.ReadLine();
                        text2 = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("The number of different lines is {0} and \nthe number of the same is {1}", diffLines,sameLines);
        }
    }
}
