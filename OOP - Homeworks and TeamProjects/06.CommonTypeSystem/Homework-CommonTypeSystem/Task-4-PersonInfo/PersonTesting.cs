namespace Task_4_PersonInfo
{
    using System;
    public class PersonTesting
    {
        public static void Main()
        {
            Person testSubject = new Person("Panayot");

            Console.WriteLine(testSubject.ToString());

            Person testSubject2 = new Person("Grigor", 32);

            Console.WriteLine(testSubject2.ToString());
        }
    }
}
