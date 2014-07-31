namespace Task_2_BankSystem
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
        {

        }
        public override decimal CalculateInterestAmount(int months)
        {
            if (Customer.GetType().Name == "IndividualCustomer")
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 2);
                }
            }

        }
    }
}
