using System;
using System.Collections.Generic;

namespace Task_9
{
    class GetMaxElement
    {
        static int FindBiggestNumFromGivenIndex(int[] arr, int index)
        {
            int length = arr.Length;
            int biggest = 0;
            for (int i = index; i < length; i++)
            {
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
            }
            return biggest;
        }
        static int[] SortAscendingOrder(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
        static void PrintArrayReverse(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] arr = { 7, 2, 1, 3, 0, 5, 8, 7, 8, 9 };
            int index = 2;

            Console.WriteLine(FindBiggestNumFromGivenIndex(arr, index));
            PrintArray(SortAscendingOrder(arr));
            PrintArrayReverse(arr);
        }
    }
}
