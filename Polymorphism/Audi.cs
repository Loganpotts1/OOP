using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi : Car
    {
        protected string Brand { get; } = "Audi";
        protected string Model { get; set; }

        public Audi(string color, string model) : base(color)
        {
            this.HP = 80;
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"{Brand} {Model} is {Color}, and has {HP} health left.");
        }

        public override void Repair()
        {
            this.HP = 80;
            Console.WriteLine($"{Brand} {Model} was repaired, and now has {HP} health.");
        }
    }
}
