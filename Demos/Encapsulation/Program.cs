namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle("Subaru", "Impreza", 5);
            //Console.WriteLine();
            //Vehicle.Print();
            myCar.Print();
            myCar.Drive(12.3);
            myCar.Print();
            myCar.Drive(34.3);
            myCar.Print();

            Vehicle otherCar = new Vehicle("Ford", "Explorer", 4);
            otherCar.Print();
            otherCar.Drive(1032.3);
            otherCar.Print();
            myCar.Print();

            Vehicle susCar = new Vehicle("Subaru", "Impreza", 5);
            susCar.Print();

            Vehicle defaultCar = new Vehicle();
        }
    }
}
