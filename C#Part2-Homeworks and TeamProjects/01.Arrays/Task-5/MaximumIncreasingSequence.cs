using System;

/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

namespace Task_5
{
    class MaximumIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of your array: ");
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            int lenght = 0;
            int maxLenght = 0;
            int firstIndex = 0;

            Console.WriteLine("Please enter values for your elements: ");
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            for (int j = sequence.Length - 1; j > 0; j--)
            {
                if (sequence[j] > sequence[j - 1])
                {
                    lenght++;

                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        firstIndex = j;
                    }
                }
                else
                {
                    lenght = 0;
                }
            }
            Console.Write("Your maximal increasing sequence is: ");
            for (int l = firstIndex - 1; l < firstIndex + maxLenght; l++)
            {
                Console.Write(sequence[l] + " ");
            }
            Console.WriteLine();
        }
    }
}
