using AbstractFactory.Entities;

namespace AbstractFactory.Abstract
{
    abstract class CarFactory
    {
        public abstract CarInfo CreateInfo();
        public abstract CarEngine CreateEngine();
        public abstract CarBody CreateBody();
    }
}
