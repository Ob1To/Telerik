namespace GSM_Homework
{
    using System;
    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM newPhone = GSM.IPhone4S;

            newPhone.AddingCalls(new Call(DateTime.Now, "+359888675822", 212));
            newPhone.AddingCalls(new Call(DateTime.Now, "+359123445512", 555));
            newPhone.AddingCalls(new Call(DateTime.Now, "+359885661234", 233));

            foreach (var call in newPhone.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine("Total prince of all the calls: {0:F2} euros", newPhone.TotalPriceOfCalls(0.37));

            int indexOfLongestCall = 0;
            int longestCallDuration = 0;
            for (int i = 0; i < newPhone.CallHistory.Count; i++)
            {
                if (newPhone.CallHistory[i].Duration > longestCallDuration)
                {
                    longestCallDuration = newPhone.CallHistory[i].Duration;
                    indexOfLongestCall = i;
                }
            }
            newPhone.DeletingCalls(indexOfLongestCall);
            Console.WriteLine("Total prince of all the calls: {0:F2} euros", newPhone.TotalPriceOfCalls(0.37));

            newPhone.ClearHistory();
            foreach (var call in newPhone.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
