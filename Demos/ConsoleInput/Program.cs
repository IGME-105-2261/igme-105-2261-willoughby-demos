namespace ConsoleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to my program.");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is " + name + ".");
            Console.WriteLine("It starts with the letter " + name[0]); //If index is larger than array, crash
            Console.WriteLine("Your name is " + name.Length + " characters!");
            
            Console.WriteLine("My favorite quote is \"pretty cool...\"\nThis is on another line");
            
            //Console.Write("Enter your favorite char: ");
            //char usersCharacter = (char)Console.Read();
            //Console.WriteLine(name + "'s favorite character is " + usersCharacter + "!");
            
            Console.WriteLine("pretty cool...");

            string otherName = "Austin";
            //string uppercase = otherName.ToUpper();
            otherName = otherName.ToUpper();
            Console.WriteLine(otherName);
            //Console.WriteLine(uppercase);
        }
    }
}
