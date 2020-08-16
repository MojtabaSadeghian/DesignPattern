using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.NationalCreditUnion
{
    // Concrete Product A2
    public class NationalSavingAccount : ISavingsAccount
    {
        public NationalSavingAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }
    }
    // Concrete ProductB2
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }

    // Concrete Factory 2
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount obj = new NationalLoanAccount();
            return obj;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingAccount obj = new NationalSavingAccount();
            return obj;
        }
    }
}
