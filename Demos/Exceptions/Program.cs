namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 2, 6 };
            int number = -1;

            Console.Write("Enter a whole number: ");

            int myVariable = 5;
            try
            {
                myVariable = 6;
                //Runtime exception: format exception if the user doesn't type a whole integer
                number = int.Parse(Console.ReadLine());

                //Runtime exception (divide by 0 if user enters 0)
                Console.WriteLine(numbers[2] / number);

                Console.WriteLine("Still in try");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You entered 0, but that won't work!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No, you were supposed to enter a whole number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Your number is " + number);
        }
    }
}
