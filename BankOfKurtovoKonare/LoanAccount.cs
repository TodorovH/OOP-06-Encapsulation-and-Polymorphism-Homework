using System;

namespace BankOfKurtovoKonare
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is CustomerIndividual)
            {
                if (months > 3)
                {
                    return base.CalculateInterest(months - 3);
                }
                else
                {
                    return this.Balance;
                }
            }
            if (this.Customer is CustomerCompany)
            {
                if (months > 2)
                {
                    return base.CalculateInterest(months - 2);
                }
                else
                {
                    return this.Balance;
                }
            }
            return base.CalculateInterest(months);
        }
    }
}
