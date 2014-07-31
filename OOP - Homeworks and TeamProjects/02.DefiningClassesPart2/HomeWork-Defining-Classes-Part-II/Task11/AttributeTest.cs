namespace Task11
{
    using System;
    [VersionAttribute("13.37")]
    public class AttributeTest
    {
        static void Main()
        {
            var attributes = typeof(AttributeTest).GetCustomAttributes(typeof(VersionAttribute), false);

            Console.WriteLine("Version: " + attributes[0]);
        }
    }
}
