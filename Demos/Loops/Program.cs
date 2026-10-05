namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0; // LCV - Loop Control Variable
            while (num < 5)
            {
                Console.WriteLine("Hello world");
                Console.WriteLine("Hi class");
                int a = 5;
                Console.WriteLine(a + num);
                num++;
            }
            Console.WriteLine("Done!");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            num = 0;
            while (num < name.Length)
            {
                Console.WriteLine("The letter in position {0} is: {1}", num, name[num]);
                num++;
            }

            //Console.WriteLine("In this game you will guess a number between 0 and 100.");
            //Console.Write("Please enter a number: ");
            //num = int.Parse(Console.ReadLine());

            //while (num != 42)
            //{
            //    Console.Write("Wrong! Enter another: ");
            //    num = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("You win!");

            Console.WriteLine("In this game you will guess a number between 0 and 100.");

            int guess;
            do
            {
                Console.Write("Enter a number: ");
                guess = int.Parse(Console.ReadLine());

                if(guess > 37 && guess < 47)
                {
                    Console.WriteLine("You're getting close!");
                }
                else
                {
                    Console.WriteLine("Pretty far off!");
                }
            } while (guess != 42);

            Console.WriteLine("You win!");
        }
    }
}
