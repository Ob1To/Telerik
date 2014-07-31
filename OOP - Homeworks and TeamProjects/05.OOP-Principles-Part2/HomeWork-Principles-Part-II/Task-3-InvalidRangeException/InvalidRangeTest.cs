namespace Task_3_InvalidRangeException
{
    using System;
    public class InvalidRangeTest
    {
        public static void Main()
        {
            var intException = new InvalidRangeException<int>("The range must be between 1 - 100", 1, 100);

            Console.WriteLine("Enter number to test. The number is set to be between 1 - 100");
            int number = int.Parse(Console.ReadLine());
            if (number < intException.Start || number > intException.End)
            {
                throw intException;
            }

            var startDate = DateTime.Parse("1980.1.1");
            var endDate = DateTime.Parse("2013.12.13");
            var dateException = new InvalidRangeException<DateTime>("invalid data ! Must be between 1.1.1980 - 31.12.2013",startDate,endDate);
            Console.WriteLine("Enter a date in the format: yyyy.mm.dd! Which is:[1/1/1980, 1/1/2013]");
            var testing = DateTime.Parse(Console.ReadLine());
            if (testing.CompareTo(startDate) < 0 || testing.CompareTo(endDate) > 0)
            {
                throw dateException;
            }
        }
    }
}
