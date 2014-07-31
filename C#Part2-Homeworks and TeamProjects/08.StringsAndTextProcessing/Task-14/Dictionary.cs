/* A dictionary is stored as a sequence of text lines containing 
 * words and their explanations. Write a program that enters a 
 * and translates it by using the dictionary. 
 * Sample dictionary: 
 * 
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes
 */

namespace Task_14
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, string> explanation = new Dictionary<string, string>();
            explanation[".NET"] = "platform for applications from Microsoft";
            explanation.Add("CLR", "managed execution environment for .NET");
            explanation.Add("namespace", "hierarchial organization of classes");
            explanation.Add("C#", "multi-paradigm programming language");

            Console.WriteLine("What word are you searching for: ");
            string key = Console.ReadLine();
            if (explanation.ContainsKey(key))
            {
                Console.WriteLine(explanation[key]);
            }
            else
            {
                Console.WriteLine("The word is not found !");
            }
        }
    }
}
