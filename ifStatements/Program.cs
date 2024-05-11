namespace ifStatements;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");

        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your age is : {age}");


        // Console.WriteLine($"The type of age variable is: {age.GetType()}");

        if (age < 0 || age >100) 
        {
            Console.WriteLine("you are either not born yet, or dead");
        } else 
        {
            if (age >= 18 && age < 30) 
            {
                Console.WriteLine("Welcome to the club");
            } else if (age >= 16 && age < 18 )
            {
                Console.WriteLine("you are between 16 and 18");
            } else if (age >= 30)
            {
                Console.WriteLine("You are tto old for this shit");
            }
        }


        
    }
}
