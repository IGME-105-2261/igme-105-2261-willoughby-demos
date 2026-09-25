namespace BoolsAndIfs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isPositive = 5 > 0; // True

            //isHungry = isPositive; // Assignment: setting isHungry equal to the VALUE in isPositive
            //isHungry == isPositive; // Boolean comparison: is isHungry equal to isPositive?

            //isPositive; // this is true
            //!isPositive; // this is false, ! just inverts the boolean

            string fish = "Goobit";
            //bool isHungry = false;
            string day;


            Console.Write("What day is it? ");
            //day = Console.ReadLine().ToLower().Trim();
            day = Console.ReadLine();
            day = day.ToLower();
            day = day.Trim();
            //isHungry = day == "Monday";

            //if (!isHungry) // on monday, is hungry is true. If they ARENT hungry, do the if
            if (day == "monday") 
            {
                Console.WriteLine("{0} must feed!", fish);
                Console.WriteLine("You feed {0}. They are happy now!", fish);
            }
            else
            {
                Console.WriteLine("Don't feed {0} today! They aren't hungry!", fish);
            }

            Console.WriteLine("{0} is always hungry on Monday!", fish);


            int variable = 55;
            if(variable < 50)
            {
                Console.WriteLine("Less than 50");
            }
            else if (variable < 75)
            {
                Console.WriteLine("Less than 75");
            }
            else if (variable > 100)
            {
                Console.WriteLine("Greater than 100");
            }
            else
            {
                Console.WriteLine("Idk man...");
            }

            Console.WriteLine("Anyways...");


            int myNumber = 3;
            if(myNumber > 5)
            {
                Console.WriteLine("Number is greater than 5.");

                if(myNumber < 20)
                {
                    Console.WriteLine("But less than 20!");
                }
                else
                {
                    Console.WriteLine("And greater than or equal to 20!");
                }
            }
        }
    }
}
