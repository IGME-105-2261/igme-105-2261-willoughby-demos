namespace Exam2Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factorial
            // 5! = 1 * 2 * 3 * 4 * 5
            // 4! = 1 * 2 * 3 * 4
            // 3! = 1 * 2 * 3

            // n! = (n-1)! * n
            int factorial5 = FactorialRecursive(5);
            Console.WriteLine(factorial5);

            Console.WriteLine("Hello"); //Static method call

            string myString = "Austin";
            myString.ToUpper(); // Non-static method call

            Console.WriteLine(FactorialIteration(10));
            Console.WriteLine(FactorialIteration(3));
            Console.WriteLine(FactorialIteration(8));
            Console.WriteLine(FactorialIteration(14));

            GreaterThan5(10, "Greetings");


            /*
             Instantiating an array
             Adding data to an array
             Making a literal array
             Accessing specific array elements
             Array size and valid indices
             Iterating through an array with a loop
             */

            int[] numbers; //Creating an array variable
            numbers = new int[5]; //Set numbers equal to an array of 5 ints
            //numbers = new int[] { 5, 10, 15, 20, 25 }; //Using an array literal

            numbers[0] = 5;  //10
            numbers[1] = 10; //20
            numbers[2] = 10; //20
            numbers[3] = 20; //40
            numbers[4] = 25; //50

            Console.WriteLine(numbers[3]); //Prints out 20

            Console.WriteLine(numbers.Length); //Prints the size of the array (5)

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
                Console.WriteLine(numbers[i]);
            }


            int myInteger = 10; //Value type
            int[] myArray; //Reference type
            myArray = new int[myInteger];
            myArray[0] = 10;

            Console.WriteLine(myArray.Length);

            /* Casting vs. Parsing
                Know the difference between implicit and explicit casting.
                Be able to cast values when necessary.
                Know when casting occurs when evaluating an expression.
                Understand the difference between casting and parsing
                Know how to parse common data types from Strings
            */

            //Casting -> Converting between variables/values of similar types
            int wholeNumber = 10;
            double decimalNumber = 25.14;

            // Implicit Cast
            decimalNumber = wholeNumber; //No data loss

            decimalNumber = 25.14;
            //wholeNumber = decimalNumber; //Can't implicitly cast this
            wholeNumber = (int)decimalNumber; //Explicit cast
            float floatingPointNumber = (float)decimalNumber;

            int results = (int)(12.53 / 10);

            double dResults = 12 / 10; //Integer division
            Console.WriteLine(dResults); //Prints 1

            dResults = 12 / (double)10; //Double Division
            Console.WriteLine(dResults); //Prints 1.2


            //int userAge = "20"; // Can't implicitly cast
            //int userSalary = (int)"1000000"; // Can't explicitly cast
            int userHeight = int.Parse("72");
            double itemCost = double.Parse("12.34");
        }

        public static bool GreaterThan5(int number, string message)
        {
            if(number > 5)
            {
                Console.WriteLine(message);
                Console.WriteLine("Greater than 5");
                return true;
            }
            else
            {
                Console.Write("Not greater than 5");
                return false;
            }
        }


        public static int FactorialIteration(int n)
        {
            int product = 1;

            for(int i = 1; i <= n; i++)
            {
                product *= i; 
                //i = 1, product = 1 * 1 = 1
                //i = 2, product = 1 * 2 = 2
                //i = 3, product = 2 * 3 = 6
                //i = 4, product = 6 * 4 = 24
                //i = 5, product = 24 * 5 = 120
            }

            return product;
        }

        // 5! = 24 * 5 = 120
        //      4! = 6 * 4
        //           3! = 2 * 3
        //                2! = 1 * 2
        //                     1! = 1

        public static int FactorialRecursive(int n)
        {
            // Base Case / Terminating case
            if(n <= 1)
            {
                return 1;
            }

            // Recursive Call = Calling the method again
            // n-1 is our state change
            return FactorialRecursive(n - 1) * n;
        }
    }
}
