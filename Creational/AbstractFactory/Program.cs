using System;
using AbstractFactory.Abstract;
using AbstractFactory.Entities;
using AbstractFactory.Helpers;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car(new AudiFactory());
            Car bmw = new Car(new BmwFactory());
            Car merceds = new Car(new MercedesFactory());

            audi.Print();
            bmw.Print();
            merceds.Print();

            Console.Read();
        }
    }
}
