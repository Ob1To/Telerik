
namespace Arrays_Homework
{
    using System;
    //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
    class AllocatesOf20
    {
        static void Main()
        {
            int[] Array = new int[20];

            for (int i = 0; i < Array.Length; i++)
			{
                Array[i] = i * 5;
			}
            Console.WriteLine(string.Join(", ",Array));
        }
    }
}
