using System;

namespace BankOfKurtovoKonare
{
    public abstract class Customer
    {
        private string name;

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                this.name = value;
            }
        }

        public Customer (string name)
        {
            this.Name = name;
        }
    }
}
