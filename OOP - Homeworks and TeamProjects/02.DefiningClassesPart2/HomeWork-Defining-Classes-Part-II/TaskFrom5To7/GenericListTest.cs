namespace TaskFrom5To7
{
    using System;
    class GenericListTest
    {
        static void Main()
        {

            var testList = new GenericList<int>(10);
            var rng = new Random();

            for (int i = 0; i < 15; i++)
            {
                testList.Add(rng.Next(-100, 100));
            }

            Console.WriteLine(testList);

            int indexOfMin = testList.IndexOf(testList.Min());
            int indexOfMax = testList.IndexOf(testList.Max());

            Console.WriteLine("Index of min: " + indexOfMin);
            Console.WriteLine("Index of max: " + indexOfMax);

            Console.WriteLine("Min: " + testList[indexOfMin]);
            Console.WriteLine("Max: " + testList[indexOfMax]);
        }
    }
}
