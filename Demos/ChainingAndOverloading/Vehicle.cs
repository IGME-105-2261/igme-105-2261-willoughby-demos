using System;
using System.Collections.Generic;
using System.Text;

namespace ChainingAndOverloading
{
    internal class Vehicle
    {
        //Fields (member variables)
        string make;
        string model;
        double mileage;
        int numPreviousOwners;

        //Default Constructor
        public Vehicle()
            : this("???", "???", 0)
        {
        }

        //Parameterized Constructors
        public Vehicle(string make, string model)
            : this(make, model, 0)
        {
        }

        public Vehicle(string make, string model, double mileage)
        {
            this.make = make;
            this.model = model;
            this.mileage = mileage;
            numPreviousOwners = 0;
            //Print();
        }

        //Method

        /// <summary>
        /// Prints out information about the car.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"The {make} {model} has {mileage} miles! " +
                $"It has had {numPreviousOwners} previous owners!");
        }

        /// <summary>
        /// Prints out information about the car the number of times specified.
        /// </summary>
        /// <param name="numTimes">How many times to print the info.</param>
        public void Print(int numTimes)
        {
            for(int i = 0; i < numTimes; i++)
            {
                Print();
            }
        }

        /// <summary>
        /// Prints out info about the car a specified number of times in a specified color.
        /// </summary>
        /// <param name="numTimes">The number of times to print the info</param>
        /// <param name="color">The color of the console output</param>
        public void Print(int numTimes, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < numTimes; i++)
            {
                Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Returns the mileage of the car.
        /// </summary>
        /// <returns>The cars mileage as a double.</returns>
        public double GetMileage()
        {
            return mileage;
        }
    }
}
