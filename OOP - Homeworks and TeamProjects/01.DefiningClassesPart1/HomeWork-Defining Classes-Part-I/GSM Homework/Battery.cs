namespace GSM_Homework
{
    using System.Text;
    using System;
    public class Battery
    {
        private BatteryType model;

        private decimal? hoursIdle;

        private decimal? hoursTalk;

        public enum BatteryType { LiIon, NiMH ,NiCd }

        
        public Battery(BatteryType model, decimal? hoursIdle = null, decimal? hoursTalk = null)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public decimal? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be zero or less");
                } 
                hoursTalk = value; }
            }

        public decimal? HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be zero or less");
                }
                hoursIdle = value;
            }
        }
        

        public BatteryType Model
        {
            get { return model; }
            set { model = value; }
        }
        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();
            batteryInfo.AppendLine("                      ***   BATTERY INFO   ***");
            batteryInfo.AppendLine();
            batteryInfo.AppendLine();
            batteryInfo.AppendLine("        Model:        " + this.Model);
            batteryInfo.AppendLine();
            if (this.HoursIdle != null)
            {
                batteryInfo.AppendLine("   Hours idle:        " + this.HoursIdle);
                batteryInfo.AppendLine();
            }
            if (this.HoursTalk != null)
            {
                batteryInfo.AppendLine("Hours talking:        "   + this.HoursTalk);
                batteryInfo.AppendLine();
            }
            return batteryInfo.ToString();
        }
    }
}
