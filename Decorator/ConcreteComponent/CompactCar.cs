using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent
{
    class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }
        public override double GetCarPrice() => 10000.00;

        public override string GetDescription() => Description;
    }
}
