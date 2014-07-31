//Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

namespace Task_10
{
    using System;
    class SequenceOfGiven
    {
        static void Main()
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
            Console.WriteLine("Please enter the sum you are searching for (if present)");
            int Sum = int.Parse(Console.ReadLine());

            int tempSum = 0;
            int start = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                tempSum += array[i];
                if (tempSum == Sum)
                {
                    Console.WriteLine("There is no sequence of elements because u have a number matching the sum !");
                    return;
                }
                start = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    tempSum += array[j];
                    if (tempSum == Sum)
                    {
                        Console.Write("You have found a sequence for your sum ! It is: ");
                        for (int k = start; k <= j; k++)
                        {
                            Console.Write("{0} ", array[k]);
                        }
                        Console.WriteLine();
                        return;
                    }
                }
                tempSum = 0;
            }
            Console.WriteLine("There is no sum present in the array");
        }
    }
}
