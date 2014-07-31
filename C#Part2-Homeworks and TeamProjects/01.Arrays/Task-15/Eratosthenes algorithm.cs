﻿//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


namespace Task_15
{
    using System;

    class SieveOfEratosthenes
    {
        static void Main()
        {
            int[] numbers = new int[10000001];
            bool[] prime = new bool[10000001];
            for (int i = 2; i < 10000001; i++)
            {
                numbers[i] = i;
                prime[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(10000000); i++)
            {
                for (int j = i * i; j < 10000001; j += i)
                {
                    prime[j] = false;
                }
            }
            for (int i = 0; i < 10000001; i++)
            {
                if (prime[i] == true)
                {
                    Console.Write(numbers[i]);
                    Console.Write(", ");
                }
            }
        }
    }
}
