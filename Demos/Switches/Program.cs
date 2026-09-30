namespace Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Please enter an integer: ");
            number = int.Parse(Console.ReadLine());
            /*
            if(number < 0)
            {
                Console.WriteLine("Number is negative!");
            } 
            else if (number == 10)
            {
                Console.WriteLine("Ten!");
            }
            else if (number == 5)
            {
                Console.WriteLine("Five!");
            }
            else
            {
                Console.WriteLine("Other!");
            }*/
            switch (number)
            {
                // Each case defines a single condition to check against the SAME variable
                case 10:
                    Console.WriteLine("Ten!");
                    break; // Each case must purposefully exit the case (e.g. via a break; statement)

                case 5:
                    Console.WriteLine("Five!");
                    break;

                // Range checking works, but ONLY against the same variable!
                // CANNOT overlap with another case!
                case < 0:
                    Console.WriteLine("Negative");
                    break;

                case 0:
                    Console.WriteLine("Zero! Program ending!");
                    return; //Exits out of the current Method or Function

                case 1: // Empty cases don't need a break
                case 2:
                    Console.WriteLine("Very small number!");
                    break; //Exits out of the current control structure (switch, loops, etc)

                default:
                    Console.WriteLine("Other");
                    break;
            }

            Console.WriteLine("All done!");
        }
    }
}
