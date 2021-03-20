using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class BMW : Car
    {
        protected string Brand { get; } = "BMW";
        protected string Model { get; set; }

        public BMW(string color, string model) : base(color)
        {
            this.HP = 120;
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"{Brand} {Model} is {Color}, and has {HP} health left.");
        }

        public override void Repair()
        {
            this.HP = 120;
            Console.WriteLine($"{Brand} {Model} was repaired, and now has {HP} health.");
        }
    }
}
