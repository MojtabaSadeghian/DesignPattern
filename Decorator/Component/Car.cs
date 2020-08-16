using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Component
{
    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double GetCarPrice();
    }
}
