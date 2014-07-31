namespace Task_2_BankSystem
{
    public abstract class Customer
    {
        private string phoneNumber;

        private string name;

        public Customer(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public string Name
        {
            get { return name; }
            set 
            { 
                name = value; 
            }
        }
        
    }
}
