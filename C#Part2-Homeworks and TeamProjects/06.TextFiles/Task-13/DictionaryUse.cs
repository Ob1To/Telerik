/* Write a program that reads a list of words from a file words.txt 
 * and finds how many times each of the words is contained in another file test.txt. 
 * The result should be written in the file result.txt and the words 
 * should be sorted by the number of their occurrences in descending order. 
 * Handle all possible exceptions in your methods.
 */

namespace Task_13
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    class DictionaryUse
    {
        static void Main()
        {
            Dictionary<string, int> Dictionary = new Dictionary<string, int>();
            try
            {
                StreamReader reader = new StreamReader(@"..\..\..\files\Task13Words.txt");
                using (reader)
                {
                    while (!reader.EndOfStream)
                    {
                        string word = reader.ReadLine();
                        Dictionary.Add(word, 0);
                    }
                }
                reader = new StreamReader(@"..\..\..\files\Task13Text.txt");
                using (reader)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        List<string> wordList = new List<string>(Dictionary.Keys);
                        foreach (string word in wordList)
                        {
                            string regex = String.Format("\\b{0}\\b", word);
                            MatchCollection matches = Regex.Matches(line, regex);
                            Dictionary[word] += matches.Count;
                        }
                    }
                }
                StreamWriter writer = new StreamWriter(@"..\..\..\files\Task13Results.txt");
                using (writer)
                {
                    foreach (var wordCounter in Dictionary.OrderByDescending(key => key.Value))
                    {
                        writer.Write(wordCounter.Key);
                        writer.Write("-");
                        writer.WriteLine(wordCounter.Value);
                    }
                }
                Console.WriteLine("DONE!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("io operation error!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
