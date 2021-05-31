using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "BMW", new PetrolMove());
            car.Move();
            car.movable = new GasMove();
            car.Move();
            car.movable = new ElectricMove();
            car.Move();
        }
    }
}
