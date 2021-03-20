using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Audi("white","Sv300"),
                new BMW("black", "M5")
            };

            foreach (Car car in cars)
            {
                car.ShowDetails();
            }

            BMW bmwM5 = (BMW)cars[1];

            bmwM5.ShowDetails();
        }
    }
}
