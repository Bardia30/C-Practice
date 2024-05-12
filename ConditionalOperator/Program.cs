namespace ConditionalOperator;

class Program
{
    static void Main(string[] args)
    {
        int age = -10;

        // if (age > =10)
        // {
        //     Console.WriteLine("Vslid");
        // } else {
        //     Console.WriteLine("Invalid");
        // }

        //conditional operator (like the ternary operator in JavaScript)
        //condition ? true: false;

        string result = age >= 0 ? "Valid" : "Invalid";

        Console.WriteLine(result);
    }
}
