using System;

namespace FactroyMethod
{
    class Program
    {
        static void Main()
        {
            var factroy = new SavingAcctFactory() as ICreditUnionFactory;
            var citiAcct = factroy.GetSavingsAccount("CITI-321");
            var nationalAcct = factroy.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");
        }

        //Product
        public abstract class ISavingsAccount
        {
            public decimal Balance { get; set; }
        }

        //Concrete Product1
        public class CitiSavingAcct : ISavingsAccount
        {
            public CitiSavingAcct()
            {
                Balance = 5000;
            }
        }
        //Concrete Product2
        public class NationalSavingsAcct : ISavingsAccount
        {
            public NationalSavingsAcct()
            {
                Balance = 2000;
            }
        }
        //Creator
        interface ICreditUnionFactory
        {
            ISavingsAccount GetSavingsAccount(string acctNo);
        }
        class SavingAcctFactory : ICreditUnionFactory
        {
            public ISavingsAccount GetSavingsAccount(string acctNo)
            {
                if (acctNo.Contains("CITI")) { return new CitiSavingAcct(); }
                else if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
                else
                    throw new ArgumentException("Invalid Account Number");
            }
        }

    }
}
