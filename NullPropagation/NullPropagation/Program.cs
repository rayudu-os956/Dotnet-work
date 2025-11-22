namespace NullPropagation
{
    class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main()
        {
           // Person p1=new Person(){Age=20};
           Person p1=null;
            //
            Console.WriteLine(p1?.Age);
            
        }
    }
    
}