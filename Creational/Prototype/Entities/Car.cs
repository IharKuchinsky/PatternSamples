using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Prototype.Abstract;

namespace Prototype.Entities
{
	[Serializable]
	public class Car : ICar
	{
	    public string Make { get; set; }
	    public string Model { get; set; }
		public CarEngine Engine { get; set; }
		
		public Car(string make, string model, int engineCapacity, int enginePower)
        {
            Engine = new CarEngine(engineCapacity, enginePower);
	        Make = make;
	        Model = model;
        }

		public Car Clone()
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, this);
				memoryStream.Position = 0;

				return (Car) binaryFormatter.Deserialize(memoryStream);
			}
		}

		public override string ToString()
		{
			return $"{Make} {Model} {Engine.Capacity}ltr. {Engine.Power}hp.";
		}
	}
}
