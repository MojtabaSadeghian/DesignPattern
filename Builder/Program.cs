using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        // The Client
        static void Main(string[] args)
        {
            var superBuilder = new SuperCarBuilder();
            var notSuperBuilder = new NotSoSuperCarBuilder();

            var factory = new Carfactory();
            var builders = new List<CarBuilder> {
                                superBuilder, notSuperBuilder
            };

            foreach (var b in builders)
            {
                var c = factory.Build(b);
                Console.WriteLine($"The Car requested by " +
                    $"{b.GetType().Name}: " +
                    $"\n--------------------------------------" +
                    $"\nHorse Power: {c.HorsePower}" +
                    $"\nImpressive Feature: {c.MostImpressiveFeature}" +
                    $"\nTop Speed: {c.TopSpeedMPH} mph\n");
            }
        }
    }

    // The Product class
    public class Car
    {
        public int TopSpeedMPH { get; set; }
        public int HorsePower { get; set; }
        public string MostImpressiveFeature { get; set; }
    }

    // The Builder abstract class
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void SetHorsePower();
        public abstract void SetTopSpeed();
        public abstract void SetImpressiveFeature();

        public virtual Car GetCar()
        {
            return _car;
        }
    }

    // The Director class
    public class Carfactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetHorsePower();
            builder.SetTopSpeed();
            builder.SetImpressiveFeature();
            return builder.GetCar();
        }
    }

    // The 'ConcreteBuilder1' class
    public class NotSoSuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 120;
        }
        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 70;
        }
        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Has Air Conditioning";
        }
    }

    // The ConcreteBuilder2 class
    public class SuperCarBuilder : CarBuilder
    {

        public override void SetHorsePower()
        {
            _car.HorsePower = 1640;
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 600;
        }
        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Can Fly";
        }

    }
}
