using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    // Observer
    public interface IFan
    {
        void Update(ICelebrity celebrity);
    }
}
