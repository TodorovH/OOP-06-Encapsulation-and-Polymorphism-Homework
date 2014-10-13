using System;

namespace BankOfKurtovoKonare
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is CustomerIndividual)
            {
                if (months > 6)
                {
                    return base.CalculateInterest(months - 6);
                }
                else
                {
                    return this.Balance;
                }
            }
            if (this.Customer is CustomerCompany)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return (base.CalculateInterest(months) / 2) + base.CalculateInterest(months - 12);
                }
            }
            return base.CalculateInterest(months);
        }
    }
}
