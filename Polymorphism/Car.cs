using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(string color)
        {
            this.HP = 100;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Car is {Color}, and has {HP} health left.");
        }

        public virtual void Repair()
        {
            this.HP = 100;
            Console.WriteLine($"Car was repaired, and now has {HP} health");
        }
    }
}
