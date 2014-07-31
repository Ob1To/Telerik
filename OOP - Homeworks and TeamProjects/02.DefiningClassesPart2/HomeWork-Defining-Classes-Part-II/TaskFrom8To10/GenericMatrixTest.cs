namespace TaskFrom8To10
{
    using System;
    class GenericMatrixTest
    {
        static void Main()
        {
            var first = new GenericMatrix<int>(5, 5);
            var second = new GenericMatrix<int>(5, 5);

            var rng = new Random();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    first[row, col] = rng.Next(100);
                    second[row, col] = rng.Next(100);
                }
            }

            Console.WriteLine("First Matrix:");
            Console.WriteLine(first);

            Console.WriteLine("Second Matrix:");
            Console.WriteLine(second);

            Console.WriteLine("Sum of both matrices:");
            Console.WriteLine(first + second);

            Console.WriteLine("Substraction of both matrices:");
            Console.WriteLine(first - second);

            Console.WriteLine("Multiplication of both matrices:");
            Console.WriteLine(first * second);

            var trueTest = new GenericMatrix<int>(5, 5);
            if (trueTest)
            {
                Console.WriteLine("doesn't work correctly");
            }
            else
            {
                Console.WriteLine("works correctly");
            }
        }
    }
}
