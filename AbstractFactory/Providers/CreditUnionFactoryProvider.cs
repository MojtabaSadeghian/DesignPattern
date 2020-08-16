using AbstractFactory.CitiCreditUnion;
using AbstractFactory.Interfaces;
using AbstractFactory.NationalCreditUnion;


namespace AbstractFactory.Providers
{
    class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accNo)
        {
            if (accNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
            else
            if (accNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory(); }
            else
                return null;
        }
    }
}
