using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class Vehicle
    {
        //Fields
        private string make;
        private string model;
        private int doors;
        private double mileage;

        //Constructors
        //Constructors have the same name as the class
        //They also do NOT have a return type
        public Vehicle() // Default constructor
        {
            make = "?";
            model = "?";
            doors = 4;
            mileage = 0;
        }

        //Parameterized Constructor
        public Vehicle(string make, string model, int doors)
        {
            this.make = make;
            this.model = model;
            this.doors = doors;
            mileage = 0;
        }

        public Vehicle(string make, string model, int doors, double mileage)
        {
            this.make = make;
            this.model = model;
            this.doors = doors;
            this.mileage = mileage;
        }

        //Methods
        public void Print()
        {
            Console.WriteLine($"The {make} {model} with {doors} doors has " +
                $"{mileage:F2} miles on it.");
        }

        public void Drive(double distance)
        {
            mileage += distance;
        }
    }
}
