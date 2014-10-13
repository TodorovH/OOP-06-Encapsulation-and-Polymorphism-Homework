using System;

namespace BankOfKurtovoKonare
{
    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }

        public void WithdrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
