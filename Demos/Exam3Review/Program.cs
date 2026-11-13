namespace Exam3Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value types
            int myInt;
            double myDouble;
            bool myBool;

            //Reference types
            String myString;
            int[] myIntArray;

            myString = "Austin";
            myIntArray = new int[5];

            PassArray(myIntArray);
            //for(int i = 0; i < myIntArray.Length; i++)
            //{
            //    Console.Write(myIntArray[i] + " ");
            //}
            //Console.WriteLine();
            //
            //myInt = 0;
            //PassInt(myInt);
            //Console.WriteLine(myInt);

            Vehicle myVehicle = new Vehicle(); //??? ???
            Vehicle otherVehicle = new Vehicle("Ford", "Explorer"); //Ford Explorer



            string userInput;
            Console.Write("Enter a whole number: ");
            userInput = Console.ReadLine();

            //int number = int.Parse(userInput);
            int number;
            bool validNumber = int.TryParse(userInput, out number);

            while(!validNumber)
            {
                Console.Write("Invalid input! Enter a whole number: ");
                validNumber = int.TryParse(Console.ReadLine(), out number);
            }

            Console.WriteLine(number + 10);

        }

        static void PassInt(int integer)
        {
            integer = 20;
        }

        //Passing a reference type
        static void PassArray(int[] intArr)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i * 10;
            }
        }
    }
}
