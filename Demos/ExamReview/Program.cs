/* Exam review project to prepare for Exam 1
 * Austin Willoughby - arwigm@rit.edu
 */
namespace ExamReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Casting
            //Implicit Casts
            int x = 10;
            double y = 12.5;

            y = x; // Implicit Cast

            //Explicit Casts
            x = (int)y;

            //Parsing
            string num = "12";
            //int numInt = (int)num; //No explicit or implicit cast from string to number
            int numInt = int.Parse(num);


            //Errors: Compile vs Runtime vs Logic
            //int number = "hello"; // Compile error
            double angleInRadians = 0.5;
            double sin = Math.Sin(angleInRadians);


            //Runtime Error
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);
            number++;
            Console.WriteLine("Your number + 1 is " + number);

            // Single line comment
            double test = 5.0f; // End of line comment int myVariable = 5;

            /* This is a "multi line"
              or "block" comment
              string myName = "Austin";
             */

            string myName = "Austin"; /*Put your name here*/

            // 2 Dimensional point
            int p1x = 5;
            int p1y = 1;

            // 2 Dimensional point
            int p2y = 10;
            int p2x = 4;

            // Distance calculation 
            // https://en.wikipedia.org/wiki/Euclidean_distance
            double dist = Math.Sqrt(Math.Pow(p2x - p1x, 2) + Math.Pow(p2y - p1y, 2));


        }
    }
}
