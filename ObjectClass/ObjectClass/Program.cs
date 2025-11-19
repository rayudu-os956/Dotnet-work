using System;
class Program
{
    static void Main()
    {
        System.Object obj = new Person(){PersonName = "Rayudu",Email = "Ringa@123.com"};
         
         ///access methods
       Console.WriteLine(obj.Equals(new Person(){PersonName = "Rayudu",Email = "Ringa@123.com"}));
       Console.WriteLine(obj.GetHashCode());
       Console.WriteLine(obj.ToString());
       Console.WriteLine(obj.GetType().ToString());

    }
}