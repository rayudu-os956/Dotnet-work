using ClassLibrary1;

class Program
{
    static void Main()
    {
        //Subsscriber subsscriber = new Subsscriber();

        Publisher publisher = new Publisher();

       // publisher.myEvent += subsscriber.Add;
       publisher.myEvent += (a,b) =>a+b;
        
    

        //invoke

        // publisher.RaiseEvent(10,20);
        // publisher.RaiseEvent(5,80);
        // publisher.RaiseEvent(14,22);
        Console.WriteLine(publisher.RaiseEvent(10,20));
        Console.WriteLine(publisher.RaiseEvent(5,80));
        Console.WriteLine(publisher.RaiseEvent(14,22));

    }
}