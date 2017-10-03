using AbstractFactory.Abstract;
using AbstractFactory.Entities;

namespace AbstractFactory.Imlementation
{
    class AudiFactory : CarFactory
    {
        public override CarInfo CreateInfo()
        {
            return new CarInfo { Model = "RS 7", Year = 2016 };
        }

        public override CarEngine CreateEngine()
        {
            return new CarEngine { Capacity = 4200, Power = 520 };
        }

        public override CarBody CreateBody()
        {
            return new CarBody { Type = BodyType.SportBack, Color = BodyColor.Black };
        }
    }
}
