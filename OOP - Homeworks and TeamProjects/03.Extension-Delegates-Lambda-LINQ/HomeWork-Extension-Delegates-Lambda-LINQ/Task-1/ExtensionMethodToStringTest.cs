namespace Task_1
{
    using System;
    using System.Text;
    public class ExtensionMethodToStringTest
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("testing the extension method");
            test.Append(" and now there it is");
            StringBuilder hereItIs = ExtensionStringBuilder.Substring(test, 10, 5);
            Console.WriteLine(hereItIs);
        }
    }
}
