
/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/

namespace Task_9
{
    using System;
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much elements your array will have: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfElements];
            Console.WriteLine("Please enter values for your elements");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int mostFreqNumber = array[0];
            int mostFreqCount = 1;
            int tempCount = 1;
            int tempNumber = array[0];
            for (int i = 1; i < numberOfElements; i++)
            {
                if (tempNumber == array[i])
                {
                    tempCount++;
                    if (tempCount > mostFreqCount)
                    {
                        mostFreqCount = tempCount;
                        mostFreqNumber = tempNumber;
                    }
                }
                else
                {
                    tempCount = 1;
                    tempNumber = array[i];
                }
            }
            Console.Write("{0} ({1} times)", mostFreqNumber, mostFreqCount);
            Console.WriteLine();
        }
    }
}
