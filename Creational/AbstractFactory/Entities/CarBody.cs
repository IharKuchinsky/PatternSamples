using System;

namespace AbstractFactory.Entities
{
    public enum BodyType
    {
        Sedan,
        Coupe,
        SportBack
    }

    public enum BodyColor
    {
        Black,
        Red,
        White
    }

    class CarBody
    {
        public BodyType Type { get; set; }
        public BodyColor Color { get; set; }
    }
}
