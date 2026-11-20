using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Cat : Pet
    {
        private int numBeds;

        public Cat(string name, int numBeds, string owner)
            : base(name, 2, owner)
        {
            this.numBeds = numBeds;
        }

        public override void Move()
        {
            Console.WriteLine($"Meow! {name} moves frantically searching for " +
                $"one of it's {numBeds} beds!");
        }
    }
}
