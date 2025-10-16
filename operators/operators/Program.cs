using System.Numerics;

class Program
{
    static void  Main()
    {
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);
        a += 20M;
        System.Console.WriteLine(a);
        a -= 20M;
        System.Console.WriteLine(a);
        a *= 3M;
        System.Console.WriteLine(a);

        a /= 3M;
        System.Console.WriteLine(a);

        a %= 3M;
        System.Console.WriteLine(a);


        a = 10M;
        System.Console.WriteLine(++a);
        System.Console.WriteLine(a++);
        System.Console.WriteLine(a);
        System.Console.WriteLine(--a);
        System.Console.WriteLine(a--);
        System.Console.WriteLine(a);

        bool b1 = a == 10;
        System.Console.WriteLine(b1);
        bool b2 = a != 10;
        System.Console.WriteLine(b2);
        bool b3 = a < 10;
        System.Console.WriteLine(b3);
        bool b4 = a > 10;
        System.Console.WriteLine(b4);
        bool b5 = a <= 10;
        System.Console.WriteLine(b5);

        //Logical operators 


        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7);
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8);
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9);

        //Concatineation operator 
        string name = "Scott";
        int age = 20;
        string message = "Hey " + name + "Your age is " + age + ".";
        System.Console.WriteLine(message);

        //ternary operator 
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "teenager" : "Adult";
        System.Console.WriteLine(title);



    }
}