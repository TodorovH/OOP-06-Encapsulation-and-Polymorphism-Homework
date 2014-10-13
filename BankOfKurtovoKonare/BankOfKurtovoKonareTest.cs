using System;
using System.Collections.Generic;

namespace BankOfKurtovoKonare
{
    class BankOfKurtovoKonareTest
    {
        static void Main(string[] args)
        {
            Customer gosho = new CustomerIndividual("Георги Георгиев");
            Customer troyanskaSliva = new CustomerCompany("Троянска слива ЕООД");

            Account mortgageAccInd = new MortgageAccount(gosho, 1024m, 5.3m);
            Account mortgageAccComp = new MortgageAccount(troyanskaSliva, 1024m, 5.3m);
            Account loanAccInd = new LoanAccount(gosho, 1024m, 5.3m);
            Account loanAccComp = new LoanAccount(troyanskaSliva, 1024m, 5.3m);
            Account depositAccIndBig = new DepositAccount(gosho, 1024m, 5.3m);
            Account depositAccIndSmall = new DepositAccount(gosho, 999m, 5.3m);
            Account depositAccComp = new DepositAccount(troyanskaSliva, 11024m, 4.3m);

            List<Account> accounts = new List<Account>()
            {
                mortgageAccInd,
                mortgageAccComp,
                loanAccInd,
                loanAccComp,
                depositAccIndBig,
                depositAccIndSmall,
                depositAccComp
            };

            foreach (var acc in accounts)
            {
                Console.WriteLine("{5} {0}: {1:N2}, {2:N2}, {3:N2}, {4:N2} \n", acc.GetType().Name, acc.CalculateInterest(6),
                    acc.CalculateInterest(3), acc.CalculateInterest(10), acc.CalculateInterest(13), acc.Customer.GetType().Name);
            }
        }
    }
}