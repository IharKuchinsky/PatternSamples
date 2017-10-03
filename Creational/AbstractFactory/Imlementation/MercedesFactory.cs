using AbstractFactory.Abstract;
using AbstractFactory.Entities;

namespace AbstractFactory.Imlementation
{
    class MercedesFactory : CarFactory
    {
        public override CarInfo CreateInfo()
        {
            return new CarInfo { Model = "E63 AMG", Year = 2017 };
        }

        public override CarEngine CreateEngine()
        {
            return new CarEngine { Capacity = 5200, Power = 580 };
        }

        public override CarBody CreateBody()
        {
            return new CarBody { Type = BodyType.Coupe, Color = BodyColor.White };
        }
    }
}
