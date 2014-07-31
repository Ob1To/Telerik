//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.


namespace Task_12
{
    using System;
    class Alphabet
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(65 + i);
            }
            Console.WriteLine("Please enter your word: ");

            string inputWord = Console.ReadLine();

            char[] word = inputWord.ToCharArray();
            Console.WriteLine("Your index numbers of the letters are: ");
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == alphabet[i])
                    {
                        Console.Write((alphabet[i] - 'A') + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
