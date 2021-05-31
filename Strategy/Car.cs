using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Car
    {
        private int passengers;
        private string _model;

        public Car(int Passengers,string model,IMovable mov)
        {
            passengers = Passengers;
            _model = model;
            movable = mov;
        }
        public IMovable movable { private get; set; }
        public void Move()
        {
            movable.Move();
        }
    }
}
