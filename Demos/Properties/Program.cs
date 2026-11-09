namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User myUser = new User("Austin", 31, "Senior Lecturer");

            myUser.Print();

            //myUser.name = "Big Cortland";
            //Console.WriteLine(myUser.name);

            //Can't set it, because User.Name doesn't have a setter
            //myUser.Name = "Big Cortland";
            //Can read it, because User.Name has a getter
            Console.WriteLine(myUser.Name);

            //Doesn't work because User.JobTitle doesn't have a getter
            //Console.WriteLine(myUser.JobTitle);
            //Does work, because User.JobTitle has a setter
            myUser.JobTitle = "Lecturer";
            myUser.Print();


            Console.WriteLine(myUser.Age); //Uses the getter
            myUser.Age++; //Uses the setter (and technically the getter)
            myUser.Age = 50; //Uses the setter
            Console.WriteLine(myUser.Age); //Uses the getter

            //Not good. Public field lets me set values to unexpected values
            //myUser.age = -30;
            myUser.Age = -30;
            Console.WriteLine(myUser.Age);
        }
    }
}
