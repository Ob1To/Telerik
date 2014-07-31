namespace Task_2_BankSystem
{
    using System;
    public class BankTesting
    {
        public static void Main()
        {
            var firstCustomer = new CompanyCustomer("Sabat", "+359888576322", "Sofia , Hadji Dimityr, bl. 332A");
            var secondCustomer = new IndividualCustomer("Stamat Hristov Penev", "+359887564722", "8609097621");
            var thirdCustomer = new CompanyCustomer("Hypo", "+359888546322", "Pleven , ul. Hari Popari, bl. 32B");

            var firstAcc = new LoanAccount(firstCustomer, 650.28M, 2.8M);
            Console.WriteLine("The interest amount of the first account is: {0}",firstAcc.CalculateInterestAmount(14));
            
            Console.WriteLine("The current balance of the first acc is: {0}",firstAcc.Balance);
            firstAcc.Deposit(650M);
            Console.WriteLine("First acc balance after deposit is: {0}", firstAcc.Balance);
            Console.WriteLine();


            var secondAcc = new MortageAccount(secondCustomer, 1400M, 4.5M);
            Console.WriteLine("The interest ammout of the second account is: {0}",secondAcc.CalculateInterestAmount(2));
            Console.WriteLine();

            var thirdAcc = new DepositAccount(thirdCustomer, 12600M, 5.5M);
            Console.WriteLine("Third Acc Balance is: {0}", thirdAcc.Balance);
            thirdAcc.Withdraw(5000M);
            Console.WriteLine("After the withdraw the balance of third acc is: {0}", thirdAcc.Balance);
            Console.WriteLine();


        }
    }
}
