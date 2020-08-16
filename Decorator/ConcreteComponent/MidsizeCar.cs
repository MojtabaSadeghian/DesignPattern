using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent
{
    class MidsizeCar : Car
    {
        public MidsizeCar()
        {
            Description = "Midsize Car";
        }
        public override double GetCarPrice() => 20000.00;

        public override string GetDescription() => Description;
    }
}
