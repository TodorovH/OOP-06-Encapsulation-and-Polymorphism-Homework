using System;

namespace BankOfKurtovoKonare
{
    public class CustomerIndividual : Customer
    {
        public CustomerIndividual(string name) : base(name) { }

        public override string ToString()
        {
            return string.Format("{0}", base.Name);
        }
    }
}
