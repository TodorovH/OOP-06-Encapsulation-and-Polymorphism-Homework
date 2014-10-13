using System;

namespace BankOfKurtovoKonare
{
    public class CustomerCompany : Customer
    {
        public CustomerCompany(string name) : base(name) { }

        public override string ToString()
        {
            return string.Format("{0}", base.Name);
        }
    }
}
