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
            Person p2 = new Person(){NoOfchildren = null};
            Person p3 = null;

            if (p2.NoOfchildren.HasValue)
            {
            Console.WriteLine(p1.NoOfchildren);
            Console.WriteLine(p2.NoOfchildren);
            }
        }
    }
}