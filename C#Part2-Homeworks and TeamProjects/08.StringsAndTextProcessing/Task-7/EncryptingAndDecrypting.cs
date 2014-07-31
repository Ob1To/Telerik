/* Write a program that encodes and decodes a string using 
 * given encryption key (cipher). The key consists of a sequence of characters. 
 * The encoding/decoding is done by performing XOR (exclusive or) 
 * operation over the first letter of the string with the first of the key, 
 * the second – with the second, etc. When the last key character is reached, 
 * the next is the first. */

namespace Task_7
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class EncryptingAndDecrypting
    {
        static string EncryptingTheString(string text, string key)
        {
            StringBuilder encryptedString = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                encryptedString.Append((char)(text[i] ^ key[i]));
            }
            return encryptedString.ToString();
        }
        static void Main()
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a key: ");
            string key = Console.ReadLine();

            if (key.Length < text.Length)
            {
                while (key.Length < text.Length)
                {
                    key += key;
                }
            }
            string encryptedText = EncryptingTheString(text, key);
            string decryptedText = EncryptingTheString(encryptedText, key);
            Console.WriteLine("The encrypted text is: {0}", encryptedText);
            Console.WriteLine("The decrypted text is: {0}", decryptedText);
        }
    }
}
