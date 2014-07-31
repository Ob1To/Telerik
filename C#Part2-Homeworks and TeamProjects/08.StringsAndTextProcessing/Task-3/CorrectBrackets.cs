/* Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
 */

namespace Task_3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class CorrectBrackets
    {
        static void BracketsValidation(string exp)
        {
            int leftBracket = 0;
            int rightBracket = 0;
            char[] expressionToChar = exp.ToCharArray(); //convert the string to char array so we can iterate the array char by char
            for (int i = 0; i < expressionToChar.Length; i++)
            {
                if (expressionToChar[i] == '(')
                {
                    leftBracket++;
                }
                if (expressionToChar[i] == ')')
                {
                    rightBracket++;
                }
            }
            if (rightBracket == leftBracket) // if they are even then we have correct brackets
            {
                Console.WriteLine("The Brackets are put correctly");
            }
            else
            {
                Console.WriteLine("The Brackets are put INcorretctly");
            }
        }
        static void Main()
        {
            Console.WriteLine("Please write down an expression to check: ");
            string expression = Console.ReadLine();
            BracketsValidation(expression);
        }
    }
}
