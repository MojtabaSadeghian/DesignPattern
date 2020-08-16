using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent
{
    class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "FullSize Car";
        }
        public override double GetCarPrice() => 30000.00;

        public override string GetDescription() => Description;
    }
}
