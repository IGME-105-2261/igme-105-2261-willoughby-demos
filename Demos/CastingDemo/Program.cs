namespace CastingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            //age = "Austin"; // Error

            double number = age; // Implicit Cast (int to double)

            int years = (int)2026.7; // Explicit Cast (force computer to convert double to int)
            Console.WriteLine("Years as an int: " + years);

            short x = 7;
            int y = x; // Implicit cast
            //x = y; // Error 
            x = (short)y; //Explicit cast of int to short

            double price = 19.95;
            int dollars = (int)price;
            Console.WriteLine("Dollar amount = " + dollars);



            double value = -12.54;
            double absValue = Math.Abs(value);
            Console.WriteLine("Absolute value of " + value + " is " + absValue);

            int intValue = (int)Math.Pow(5, 3);
            Console.WriteLine("5 raised to the power 3 is " + intValue);
        }
    }
}
