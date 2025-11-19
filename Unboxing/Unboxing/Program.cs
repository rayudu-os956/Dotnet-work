using System;
class Program
{
    static void Main()
    {
        //reference variable
        object  obj =10;

        //uboxing (refernce-type to value -type)
        int x = (int)obj;
        Console.WriteLine(x);
        Console.WriteLine(obj);


    }
}