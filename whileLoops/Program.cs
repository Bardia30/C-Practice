namespace whileLoops;

class Program
{
    static void Main(string[] args)
    {
        // int i = 0;

        // while (i <= 10)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }

        Console.Write("Enter a first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a second Number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int answer = firstNumber * secondNumber;

        Console.Write("What the is multiplication of these two numbers? ");
        int userAnswer = Convert.ToInt32(Console.ReadLine());

        while (answer != userAnswer)
        {
            Console.Write("Try again: ");
            userAnswer = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("You guessed it correctly");



        // do 
        // {
        //     //does sth 
        // } while (condition) //if condition is true, it will loop back the do statement

    }
}
