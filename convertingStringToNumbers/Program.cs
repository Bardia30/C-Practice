namespace convertingStringToNumbers;

class Program
{
    static void Main(string[] args)
    {   
        string textAge = "-23";
        int age = Convert.ToInt32(textAge);
        Console.WriteLine(age);

        //Long
        string bigNumberText = "9000000";
        long bigNumber = Convert.ToInt64(bigNumberText);
        Console.WriteLine(bigNumber);

        //double
        string negativeText = "-24.34";
        double negative = Convert.ToDouble(negativeText);
        Console.WriteLine(negative);

        //Float
        string precisionText = "55.001";
        float precision = Convert.ToSingle(precisionText);
        Console.WriteLine(precision);


        //decimal 
        string moneyText = "14.99";
        decimal money = Convert.ToDecimal(moneyText);   
        Console.WriteLine(money);   
    }
}
