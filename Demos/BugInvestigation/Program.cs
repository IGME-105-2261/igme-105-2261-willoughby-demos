namespace BugInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myVariable = 5;
            int divisor = 3;
            //...
            divisor -= 2;
            //...
            Console.WriteLine(myVariable / divisor);


            double myDouble = 100.0;
            Console.WriteLine(myDouble / 0);
            Console.WriteLine(0.0 / 0.0);
        }
    }
}
