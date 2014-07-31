namespace Task_2_BankSystem
{
    public class MortageAccount : Account
    {
        public MortageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            
        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer.GetType().Name == "IndividualCustomer")
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 6);
                }
            }
            else
            {
                if (months <= 12)
                {
                    return(base.CalculateInterestAmount(months) / 2);
                }
                else
                {
                    return(base.CalculateInterestAmount(12) / 2) + (base.CalculateInterestAmount(months - 12));
                }
            }
        }
    }
}
