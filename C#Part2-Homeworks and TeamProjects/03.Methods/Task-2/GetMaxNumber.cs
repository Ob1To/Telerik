/*Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

namespace Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class GetMaxNumber
    {
        static int GetMax(int first, int second)
        {
            int biggest = first;
            if (second > biggest)
            {
                biggest = second;
            }
            return biggest;
        }
        static void Main()
        {
            Console.WriteLine("Please enter 3 numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int biggest = GetMax(n1, n2);
            biggest = GetMax(biggest, n3);
            Console.WriteLine("Your biggest number is {0}",biggest);
        }
    }
}
