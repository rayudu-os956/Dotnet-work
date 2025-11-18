using System;
class Program
{
    static void Main()
    {
        //create structure instance
        Categroy categroy = new Categroy(); //its for intialised the struture not an object 
        //inittialiswwe fields throough properties 
        categroy.CategoryID =20;
        categroy.CategroyName = "General";

        //access methods 
        Console.WriteLine(categroy.GetCategroyNameLength());
        Console.WriteLine(categroy.CategoryID);
        Console.WriteLine(categroy.CategroyName);

    }
}