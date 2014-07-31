/*Write a program that reads two integer numbers N and K and an array of N elements from the console.
 Find in the array those K elements that have maximal sum.*/

namespace Task_6
{
    using System;
    class FindElementsWithMaxSum
    {

        static void Main()
        {
            Console.WriteLine("Please Enter value for N and K where N is the number of elements for your array and K is number of elements with maximum sum that will you will see");
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K: ");
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            Console.WriteLine("Now enter values for your elements");
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You have chosen to show you {0} elements with the maximum sum and they are: ", K);
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
