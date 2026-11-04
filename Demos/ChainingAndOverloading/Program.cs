namespace ChainingAndOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle();

            myCar.Print();

            Vehicle otherCar = new Vehicle("Subaru", "Outback");
            otherCar.Print(5, ConsoleColor.Magenta);

            Vehicle usedCar = new Vehicle("Ford", "Escape", 45931.8);
            usedCar.Print(3);

            usedCar.Print(2, ConsoleColor.Yellow);
        }
    }
}
