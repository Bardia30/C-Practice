namespace operators;

class Program
{
    static void Main(string[] args)
    {
        int age = 23;

        //all do the same
        age++;

        age += 1;

        age = age + 1;


        age -=1;

        age--;

        // Console.WriteLine(age / 10);


        //for divisions, use double, to get a double result, if use int, it will be rounded
        double doubleAge = 26;

        // Console.WriteLine(doubleAge / 10);


        string name = "aba";

        name += " is programming!";

        Console.WriteLine(name);



        char a = 'a';

        a += 'b';

        //adds their unicode character codes and gives the result
        // Console.WriteLine(a);


        int i = 0;

        // Console.WriteLine(i++); // --> 0 
        // Console.WriteLine(i); // --> 1

        // Console.WriteLine(++i); // --> 1
        // Console.WriteLine(i); //  --> 1




        //remainder %
        int firstNum = 10;
        int secondNum = 3;


        // Console.WriteLine(firstNum / secondNum); --> 3

        // Console.WriteLine(firstNum % secondNum); --> 1

        // Console.WriteLine(Convert.ToDouble(firstNum)/ secondNum); --> 3.3333333

        //10 % 2 = 0 --> even 
        //11 % 2 = 1 --> odd




        //another way of declaring variables
        //var keyword

        var age2 = 27;

        var bigNumber = 1000L;

        var negative = -44.3D;

        var precision = 45.4234F;

        var name2 = "Bardia";

        //NOTE: be careful with using the var keyword
        //  it might take away from readability of the code

        



    }
}
