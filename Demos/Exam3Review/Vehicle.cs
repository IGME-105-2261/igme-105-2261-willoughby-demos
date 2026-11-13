using System;
using System.Collections.Generic;
using System.Text;

namespace Exam3Review
{
    internal class Vehicle
    {
        //Fields
        private string make;
        private string model;
        private double mileage;
        private double topSpeed;

        //Constructors
        public Vehicle()
            : this("???", "???") //Calls the param constructor for this object
        {
        }

        public Vehicle(string make, string model)
        {
            this.make = make;
            this.model = model;
            mileage = 0;
            topSpeed = 40;
        }
    }
}
