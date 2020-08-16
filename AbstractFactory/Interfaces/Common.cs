using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    // Abstract Factory
    public abstract class ICreditUnionFactory
    {
        public abstract ILoanAccount CreateLoanAccount();
        public abstract ISavingsAccount CreateSavingsAccount();
    }

    // Abstract Product A
    public interface ILoanAccount { }

    // Abstract Product B
    public interface ISavingsAccount { }
}
