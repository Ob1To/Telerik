namespace Task_2_BankSystem
{
    using System;
    public class DepositAccount : Account, IWithdraw
    {
        // constructor
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        // Methods
        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new ArgumentException("Sorry , you don't have sufficient balance for the transaction !!!");
            }
            else
            {
                this.Balance -= amount;
            }
        }


        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(months);
            }
        }
    }
}
