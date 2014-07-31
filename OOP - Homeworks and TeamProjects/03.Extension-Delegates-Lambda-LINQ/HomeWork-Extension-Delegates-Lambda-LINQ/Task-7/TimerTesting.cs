// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace Task_7
{
    using System;
    public class TimerTesting
    {
        static void Main()
        {
            TimerEvent testDelegate = Console.WriteLine;
                        
            Timer tr = new Timer(testDelegate, "Yo yo yo i'm testing here", 12, 2);

            tr.ExecuteMethod();
        }
    }
}
