namespace Human
{
    using System;
    public class Worker : Human
    {
        private uint weekSalary;
        private byte workHoursPerDay;


        public Worker()
        {

        }
        public Worker(string firstName, string lastName, uint weekSalary, byte workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public byte WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Working hours cannot be less then 0");
                }
                else
                {
                    workHoursPerDay = value;
                }
            }
        }
        

        public uint WeekSalary
        {
            get { return weekSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative number");
                }
                else
                {
                    weekSalary = value; 
                }
            }
        }
        public double MoneyPerHour()
        {
            double moneyPerHour = (((double)weekSalary / 5) / (double)workHoursPerDay);
            return moneyPerHour;
        }
        
    }
}
