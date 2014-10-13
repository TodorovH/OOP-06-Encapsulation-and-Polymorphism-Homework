using System;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Customer Customer 
        { 
            get
            {
                return this.customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The customer cannot be empty.");
                }
                this.customer = value;
            }
        }

        public decimal Balance
        { 
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate 
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public Account (Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + this.InterestRate * months);
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
