using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) 
            : base(car)
        {
            Description = "Sunroof";
        }

        public override string GetDescription() => 
                                $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice()
        {
            return _car.GetCarPrice() + 2500;
        }
    }
}
