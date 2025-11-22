namespace namespace1
{
    class Person
    {
        public int? NoOfchildren;
    }
    class Program
    {
        static void Main()
        {
            Person p1 = new Person(){NoOfchildren =2};
            Person p2 = new Person(){NoOfchildren = 3};
            Person p3 = null;
            //Console.WriteLine(p1.NoOfchildren);
            Console.WriteLine(p2.NoOfchildren ??0);
            
        }
    }
}