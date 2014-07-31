namespace GSM_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Call
    {
        private DateTime date;
        private string dialedPhoneNumber;
        private int duration;


        public Call(DateTime date, string dialedPhoneNumber, int durationInSeconds)
        {
            this.Date = date;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = durationInSeconds;
        }

        public DateTime Date
        {
            get { return date; }
            private set { date = value; }
        }
        public string DialedPhoneNumber
        {
            get { return dialedPhoneNumber; }
            private set { dialedPhoneNumber = value; }
        }
        
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();
            callInfo.AppendLine("                      ***   Call Information   ***");
            callInfo.AppendLine();
            callInfo.AppendLine();
            callInfo.AppendLine("                Date:     " + this.Date);
            callInfo.AppendLine();
            callInfo.AppendLine("Dialed Phone Number :     " + this.DialedPhoneNumber);
            callInfo.AppendLine();
            callInfo.AppendLine("            Duration:     " + this.Duration);
            callInfo.AppendLine();

            return callInfo.ToString();
        }
    }
}
