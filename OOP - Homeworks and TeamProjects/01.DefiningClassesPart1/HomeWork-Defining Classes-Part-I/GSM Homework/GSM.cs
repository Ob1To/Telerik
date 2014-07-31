using System.Text;
using System;
using System.Collections.Generic;
namespace GSM_Homework
{
    public class GSM
    {
        private string model;

        private string manufacturer;

        private double? price;

        private string owner;

        private Battery battery = new Battery(Battery.BatteryType.LiIon);

        private Display display = new Display();

        private static GSM iPhone4S = new GSM("4S", "Apple", 200, "Ivan4o", new Display(3.5, 16000000), new Battery(Battery.BatteryType.LiIon, 200, 14));

        private List<Call> callHistory = new List<Call>();

              
        public GSM(string model, string manufacturer, double? price = null, string owner = null, Display display = null, Battery battery = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        public Display Display
        {
            get { return display; }
            set { display = value; }
        }
        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public string Owner
        {
            get { return owner; }
            set
            {
                if (value != null && value.Length < 2)
                {
                    throw new ArgumentException("Name must be at least 2 characters");
                }
                this.owner = value;
            }
        }
        
        public double? Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Value of your phone must be more then 0 euro");
                }
                price = value; 
            }
        }
        
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The value must be long at least 2 characters");
                }
                manufacturer = value; 
            }
        }
        
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model can't be null or empty.");
                }
                model = value; 
            }
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }
        public void AddingCalls(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeletingCalls(int positionToDelete)
        {
            this.CallHistory.RemoveAt(positionToDelete);
        }

        public double TotalPriceOfCalls(double pricePerMinute )
        {
            double priceToPay = 0;
            foreach (var call in this.CallHistory)
            {
                priceToPay += call.Duration;
                priceToPay /= 60;
            }
            return priceToPay * pricePerMinute;
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("                      ***   INFO FOR YOUR MOBILE   ***");
            info.AppendLine();
            info.AppendLine();
            info.AppendLine("        Model:        " + this.Model);
            info.AppendLine();
            info.AppendLine(" Manufacturer:        " + this.Manufacturer);
            info.AppendLine();
            if (this.Price != null)
            {
                info.AppendLine("        Price:        " + this.Price + " euro");
                info.AppendLine();
            }
            if (this.Owner != null)
            {
                info.AppendLine("        Owner:        " + this.Owner);
                info.AppendLine();
                info.AppendLine();
            }
            if (this.Battery != null)
            {
                info.AppendLine(this.Battery.ToString());
                info.AppendLine();
            }
            if (this.Display != null)
            {
                info.AppendLine(this.Display.ToString());
                info.AppendLine();
            }
            return info.ToString();
        }
        
    }
}
