using System;

namespace Prototype.Entities
{
	[Serializable]
	public class CarEngine
    {
        public int Capacity { get; set; }
        public int Power { get; set; }

	    public CarEngine(int capacity, int power)
	    {
		    Capacity = capacity;
		    Power = power;
	    }
    }
}
