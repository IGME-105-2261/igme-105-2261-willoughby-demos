using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    abstract internal class Pet
    {
        protected string name;
        protected int age;
        protected string owner;

        protected Pet(string name, int age, string owner)
        {
            this.name = name;
            this.age = age;
            this.owner = owner;
        }

        public abstract void Move();
    }
}
