/* Write a program that reads a text file containing a list of strings, 
 * sorts them and saves them to another text file. 
 * Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
 */

namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class SortedNames
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\ListNames.txt");
            string lines = reader.ReadLine();
            List<string> names = new List<string>();
            using (reader)
            {
                while (lines != null)
                {
                    names.Add(lines);
                    lines = reader.ReadLine();
                }
            }
            names.Sort();
            StreamWriter writer = new StreamWriter(@"..\..\..\files\SortedNamesList.txt");
            using (writer)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }
            Console.WriteLine("Operation complete.");
        }
    }
}
