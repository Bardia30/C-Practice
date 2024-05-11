namespace consoleOutput;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Enter your name: ");

        // var userInput = Console.ReadLine();

        // Console.WriteLine($"User's input is {userInput}");

        // //string concatenation
        // Console.WriteLine("Your name is " + userInput + ". Very nice to meet you!");

        Console.Write("Enter your age: ");

        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your age is : {age}");


        Console.WriteLine($"The type of age variable is: {age.GetType()}");
    }
}
