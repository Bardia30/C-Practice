namespace ConstKeyword;

class Program
{
    static void Main(string[] args)
    {
        const int hst = 13;

        // hst = 20;

        // Console.WriteLine(hst);

        const double percentHST = hst / 100D;

        Console.WriteLine(percentHST);

        int balance = 1000;

        // Console.WriteLine(balance * percentHST);

        const string version = "V1.2.3";

        //Exercise

        /*
        create & initialize two ints
        make a variable to work out the remainder
        output remainder to the screen 
        change the first int variable to another number 
            and recalculate the remainder
            output new remainder to the screen 
        */

        int number1 = 46;
        int number2 = 23;

        var remainder12 = number1 % number2;

        Console.WriteLine(remainder12);

        number1 = 48;
        remainder12 = number1 % number2;
        Console.WriteLine(remainder12);

    }
}
