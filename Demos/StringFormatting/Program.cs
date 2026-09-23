namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Literal - Quoted String
            Console.WriteLine("Hello, World!");

            //String literal w/ escape characters
            Console.WriteLine("Hello\nNew Line.");
            Console.WriteLine("\tMika says \"Meow\"");

            /* Verbatim string - Exactly as it is, including
             * new lines, tabs, spaces, etc...
             * Double quotes need to be doubled
             */
            Console.WriteLine(@"\tMika\nsays
                ""hi""");

            /* Raw string - Like verbatim, but without a special
             * case for double quote. Also spacing is relative to
             * the closing line.
             */
            Console.WriteLine("""
                Austin\n

                        "Willoughby"
                """);

            string myString = """
                Austin
                    Robert
                        Willoughby
                """;
            Console.WriteLine(myString);


            double value = 10.0 / 3;
            int number = (int)value;
            Console.WriteLine("Double: " + value);
            Console.WriteLine("Integer: " + number);


            /* Format strings
             */
            int apples = 1256;
            double price = apples * 1.19;
            Console.WriteLine(apples + " apples cost " + price);
            Console.WriteLine(
                "{0} apples cost {1}", 
                apples, // 0 
                price); // 1

            price = 2.0 / 3; //Price of a single apple
            Console.WriteLine(
                "Apples cost {1:C} each. {0:D10} apples cost {2:C} total.",
                apples, //0
                price, //1
                apples * price //2
                );

            string formattedString = String.Format("My name is {0}. I have {1} apples.", 
                "Austin Willoughby",
                apples);
            Console.WriteLine(formattedString);

            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            
            // You have to know how to do this
            Console.WriteLine(
                "Welcome, {0}. I have {1} apples. Are you jealous?", 
                userName, 
                apples);

            Console.WriteLine($"Welcome, {userName}. I have {apples} apples. Are you jealous?");
        }
    }
}
