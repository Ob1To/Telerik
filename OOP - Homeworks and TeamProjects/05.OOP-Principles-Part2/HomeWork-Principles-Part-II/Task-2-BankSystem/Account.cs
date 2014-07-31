namespace Task_2_BankSystem
{
    using System;
    public abstract class Account : IDeposit
    {
        private decimal balance;

        private decimal interestRate;

        private Customer customer;


        
        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }


        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        

        public decimal InterestRate
        {
            get { return interestRate; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative.");
                }
                else
                {
                    interestRate = value; 
                }
            }
        }
        

        public decimal Balance
        {
            get { return balance; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    balance = value; 
                }
            }
        }


        public virtual decimal CalculateInterestAmount(int months)
        {
            return months * this.InterestRate;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
