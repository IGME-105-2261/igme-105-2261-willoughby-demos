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
                num++;
            }
            Console.WriteLine("Done!");
            num = 3;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello world");
            }
            Console.WriteLine("Done!");


            for (int i = 100; i > 0; i /= 3)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();



            for(int h = 0; h < 5; h++)
            {
                for(int w = 0; w < 3; w++)
                {
                    Console.WriteLine("({0}, {1})", w, h);
                }
            }






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
