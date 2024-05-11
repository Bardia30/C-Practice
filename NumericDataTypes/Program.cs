namespace FreeCode;

class Program
{
    static void Main(string[] args)
    {
        //Numeric Data Types
        
        int age = 26;
        Console.WriteLine($"Age: {age}");

        //Long
        long bigNumber = 90000000L;

        Console.WriteLine(bigNumber);

        //double

        double negative = -24.3D;

        Console.WriteLine(negative);
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);


        //Float

        float precision = 55.001F;


        //decimal 
        decimal money = 14.99M;
        Console.WriteLine(money);

        //syntax tip
        // int x = 10;
        // int y= 20;
        // int z = 30;

        int x = 10,
            y = 20,
            z = 30;
        


    }
}
