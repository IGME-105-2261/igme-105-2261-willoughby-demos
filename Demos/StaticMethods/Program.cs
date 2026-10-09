namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1Name;
            string p2Name;

            string myString = "The value is " + 5;
            //"The value is 5"

            p1Name = GetUserInput("Enter Player 1's name");
            p2Name = GetUserInput("Enter Player 2's name");

            Console.WriteLine("Welcome {0} and {1}!", p1Name, p2Name);

            /*
            string p1Name;
            string p2Name;

            Console.Write("Enter Player 1's name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            p1Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter Player 2's name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            p2Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Hello {0} and {1}!", p1Name, p2Name);
            */
        }

        /* Method for getting user input with text highlighting
         *      - Prompt the user for some kind of input
         *      - Change the color to cyan
         *      - Get the input from the user
         *      - Change the color back to white
         *      
         * What information do we need from the programmer? (Parameters)
         *      - The prompt to ask the user
         * 
         * What information (if any) do we need to return to the programmer?
         *      - Whatever the user typed in
         */
        public static string GetUserInput(string prompt)
        {
            string userInput;

            //Prompt the user for some kind of input
            Console.Write(prompt + ": ");

            //Change the color to cyan
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Get the input from the user
            userInput = Console.ReadLine();

            //Change the color back to white
            Console.ForegroundColor = ConsoleColor.White;

            if(userInput == "Austin")
            {
                return "Mr. Pibb";
            }

            Console.WriteLine("Okay you aren't Mr. Pibb...");
            return userInput;
        }
    }
}
