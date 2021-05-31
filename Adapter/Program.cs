using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Traveler traveler = new Traveler();
            Car car = new Car();
            Animal animal = new Animal();
            ITransport animalTranspor = new AnimalToTransport(animal);
            traveler.Travel(car);
            traveler.Travel(animalTranspor);
        }
    }
}
