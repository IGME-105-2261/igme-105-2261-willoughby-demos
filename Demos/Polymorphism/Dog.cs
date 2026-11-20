using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Dog : Pet
    {
        public Dog(string name, string owner)
            :base(name, 1, owner)
        {

        }

        public override void Move()
        {
            //...
            Console.WriteLine($"{name} moves!");
        }

        public void Bark()
        {
            Console.WriteLine($"{name} says: \"Woof!\"");
        }
    }
}
