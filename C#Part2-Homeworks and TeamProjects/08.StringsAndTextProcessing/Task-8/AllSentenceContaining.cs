/* Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:
 * 
 * We are living in a yellow submarine. 
 * We don't have anything else. 
 * Inside the submarine is very tight. 
 * So we are drinking all the day. 
 * We will move out of it in 5 days.

	The expected result is:
    We are living in a yellow submarine.
    We will move out of it in 5 days.

		Consider that the sentences are separated by "." and the words – by non-letter symbols. */

namespace Task_8
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class AllSentenceContaining
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] sentences = text.Split('.');
            Console.WriteLine("Please enter search word , for example \"in\": ");
            string searchWord = Console.ReadLine();
            string sentencesToPrint = "";
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] += ".";
                for (int j = 0; j < sentences[i].Length - searchWord.Length; j++)
                {
                    if (sentences[i].Substring(j,searchWord.Length) == searchWord)
                    {
                        string temp2 = sentences[i].Substring(j + searchWord.Length,1).ToLower();
                        if (j == 0)
                        {
                            if (temp2[0] > 'z' || temp2[0] < 'a')
                            {
                                sentencesToPrint += sentences[i];
                                break;
                            }
                        }
                        else
                        {
                            string temp = sentences[i].Substring(j - 1, 1).ToLower();
                            if ((temp[0] > 'z' || temp[0] < 'a') && (temp2[0] > 'z' || temp2[0] < 'a'))
                            {
                                sentencesToPrint += sentences[i];
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sentencesToPrint);
        }
    }
}
