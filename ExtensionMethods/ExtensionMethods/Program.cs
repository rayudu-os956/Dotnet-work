using ClassLibrary1;

namespace ExenstionMethods
{
    class Program
    {
        static void Main()
        {
            Product p = new Product(){ProductCost =1000,DiscountPercentage =10 };
           Console.WriteLine( p.GetDiscount());
        }
    }
}