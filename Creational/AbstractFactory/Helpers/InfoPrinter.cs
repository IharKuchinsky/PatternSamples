using System;
using AbstractFactory.Entities;

namespace AbstractFactory.Helpers
{
    static class InfoPrinter
    {
        public static void Print(this Car car)
        {
            Console.WriteLine($"Model: {car.Info.Model}, {car.Info.Year}");
            Console.WriteLine($"Body: {car.Body.Type}, {car.Body.Color}");
            Console.WriteLine($"Engine: {(double)car.Engine.Capacity / 1000} ltr., {car.Engine.Power} HP");

            Console.WriteLine();
        }
    }
}
