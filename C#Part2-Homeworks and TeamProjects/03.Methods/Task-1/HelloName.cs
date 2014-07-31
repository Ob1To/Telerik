//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.



namespace Task_1
{
    using System;
    class HelloName
    {
        static void PrintName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
        }
        static void Main()
        {
            PrintName();
        }
    }
}
