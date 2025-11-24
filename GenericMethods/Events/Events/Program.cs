using ClassLibrary1;

class Program
{
    static void Main()
    {
        //Subsscriber subsscriber = new Subsscriber();

        Publisher publisher = new Publisher();

       // publisher.myEvent += subsscriber.Add;
       publisher.myEvent += delegate(int a , int b)
       {
        int c = a+b;
           Console.WriteLine(c);
       };

        //invoke

        publisher.RaiseEvent(10,20);
        publisher.RaiseEvent(5,80);
        publisher.RaiseEvent(14,22);

    }
}