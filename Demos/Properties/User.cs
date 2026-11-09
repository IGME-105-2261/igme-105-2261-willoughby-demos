using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    internal class User
    {
        //Fields
        private string name;
        private int age;
        private string jobTitle;
        private int numTimesAgeChanged;

        //Properties
        public string Name
        {
            //Getter allows people to read the name
            get { return name; }

            //No setter, so they can't change the name
        }

        /// <summary>
        /// Property for User's age. Min value of 0
        /// </summary>
        public int Age
        {
            //Getter allows us to read the age
            get { return age; }

            //Setter allows us to set the age
            set 
            {
                if(value >= 0)
                {
                    numTimesAgeChanged++;
                    Console.WriteLine($"Happy birthday to {name}!");
                    age = value;
                }
            }
        }

        public string JobTitle
        {
            //No getter, so they can't read the value

            //Setter, so they can change the value
            set { jobTitle = value; }
        }

        //Constructor
        public User(string name, int age, string jobTitle)
        {
            this.name = name;
            this.age = age;
            this.jobTitle = jobTitle;
            numTimesAgeChanged = 0;
        }

        //Methods
        public void Print()
        {
            Console.WriteLine($"The user {name} is {age} years old. They work as a {jobTitle}.");
        }
    }
}
