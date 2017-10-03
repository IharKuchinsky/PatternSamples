using AbstractFactory.Abstract;
using AbstractFactory.Entities;

namespace AbstractFactory.Imlementation
{
    class BmwFactory : CarFactory
    {
        public override CarInfo CreateInfo()
        {
            return new CarInfo { Model = "M5", Year = 2015 };
        }

        public override CarEngine CreateEngine()
        {
            return new CarEngine { Capacity = 4400, Power = 520 };
        }

        public override CarBody CreateBody()
        {
            return new CarBody { Type = BodyType.Sedan, Color = BodyColor.Red };
        }
    }
}
