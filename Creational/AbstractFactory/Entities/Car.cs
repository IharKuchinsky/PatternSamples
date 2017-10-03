using AbstractFactory.Abstract;

namespace AbstractFactory.Entities
{
    class Car
    {
        public CarInfo Info { get; }
        public CarEngine Engine { get; }
        public CarBody Body { get; }

        public Car(CarFactory carFactory)
        {
            Info = carFactory.CreateInfo();
            Engine = carFactory.CreateEngine();
            Body = carFactory.CreateBody();
        }
    }
}
