namespace Task_7
{
    using System;
    using System.Threading;

    public delegate void TimerEvent(string str);
    public class Timer
    {

        public TimerEvent Del { get; set; }

        public string SomeText { get; set; }

        public int Repeat { get; set; }

        public int Seconds { get; set; }

        public Timer(TimerEvent del, string sometext, int repeat , int seconds)
        {
            this.Del = del;
            this.SomeText = sometext;
            this.Seconds = seconds;
            this.Repeat = repeat;
        }

        public void ExecuteMethod()
        {
            while (this.Repeat != 0)
            {
                Thread.Sleep(this.Seconds * 1000);
                this.Del(SomeText);
                this.Repeat--;
            }
        }
    }
}
