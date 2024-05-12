namespace forLoops;

class Program
{
    static void Main(string[] args)
    {
        //for loops (iteration) (very similar to JavaScript)
        // int counter = 0;
        // for (int i = 0; i< 10; i++) 
        // {
        //     Console.WriteLine($"Hi number: {counter + 1}");
        //     counter++;
        // }

        // for (int i = 1; i <= 10; i += 2)
        // {
        //     Console.WriteLine(i);
        // }

        Console.Write("how many times do you want to say h?:  ");

        int userTimes = Convert.ToInt32(Console.ReadLine());

        Console.Write("What do you want to repeat? ");

        string userMessage = Console.ReadLine();

        if (userTimes <= 0 )
        {
            Console.WriteLine("Your value has to be larger than 0");
        }

        for (int i = 0;  i < userTimes; i++) 
        {
            Console.WriteLine(userMessage);
        }
    }
}
