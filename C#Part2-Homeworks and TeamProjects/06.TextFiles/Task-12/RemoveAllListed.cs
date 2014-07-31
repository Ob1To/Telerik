/* 
 * Write a program that removes from a text file all words 
 * listed in given another text file. 
 * Handle all possible exceptions in your methods.
 */

namespace Task_12
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class RemoveAllListed
    {
        static void Main()
        {
            try
            {
                List<string> list = new List<string>();
                StreamReader reader = new StreamReader(@"..\..\..\files\Task12SourceWords.txt");
                using (reader)
                {
                    string word = reader.ReadLine();
                    while (word != null)
                    {
                        list.Add(word);
                        word = reader.ReadLine();
                    }
                }
                reader = new StreamReader(@"..\..\..\files\Task12Text.txt");
                StreamWriter writer = new StreamWriter(@"..\..\..\files\Task12Results.txt");
                using(reader)
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            string word = list[i];
                            line = line.Replace(word, " ");
                        }
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
                Console.WriteLine("Operation Complete !");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not open the file.");
            }
        }
    }
}
