namespace Task_2_BankSystem
{
    using System;
    public class CompanyCustomer : Customer
    {
        private string address;


        public CompanyCustomer(string name, string phoneNumber, string address) : base(name, phoneNumber)
        {
            this.Address = address;
        }

        public string Address
        {
            get { return address; }

            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                address = value; 
            }
        }
        
    }
}
