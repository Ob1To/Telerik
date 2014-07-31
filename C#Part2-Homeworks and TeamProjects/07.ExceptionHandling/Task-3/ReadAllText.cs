/* Write a program that enters file name along with its full file 
 * path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 */

namespace Task_3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class ReadAllText
    {
        static void PrintFile(string path)
        {
            string theFile = File.ReadAllText(path);
            Console.WriteLine(theFile);
        }
        static void Main()
        {
            Console.WriteLine("Please enter the full path to the file: ");
            try
            {
                string filePath = Console.ReadLine();
                PrintFile(filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The given path is in an invalid format.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O (Input/Output) error occurred while opening the file.");
            } 
        }
    }
}
