namespace Task_2_BankSystem
{
    using System;

    public class IndividualCustomer : Customer
    {
        private string egn;


        public IndividualCustomer(string name, string phoneNumber, string egn) : base(name, phoneNumber)
        {
            this.EGN = egn;
        }


        public string EGN
        {
            get { return egn; }

            protected set 
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("EGN number must be 10 digits long");
                }
                else
                {
                    egn = value; 
                }
            }
        }
        
    }
}
