using ClassLibrary1;

class Program
{
    static void Main()
    {
        Program p = new Program();
        p.DoWork();
        //Subsscriber subsscriber = new Subsscriber();

    //     Publisher publisher = new Publisher();

    //    // publisher.myEvent += subsscriber.Add;
    //    //publisher.myEvent += (a,b) =>a+b;
    //   // publisher.myEvent += (a,b) =>
    //      publisher.myEvent += (
    //         sender ,e) =>

    //    {
    //     //    int c =a+b;
    //        int c =e.a+e.b;
    //       Console.WriteLine(c);

    //    };
        
    

    //     //invoke

    //     // publisher.RaiseEvent(10,20);
    //     // publisher.RaiseEvent(5,80);
    //     // publisher.RaiseEvent(14,22);
    //     // Console.WriteLine(publisher.RaiseEvent(10,20));
    //     // Console.WriteLine(publisher.RaiseEvent(5,80));
    //     // Console.WriteLine(publisher.RaiseEvent(14,22));

    
}

public void DoWork()
{
         Publisher publisher = new Publisher();

    //    // publisher.myEvent += subsscriber.Add;
    //    //publisher.myEvent += (a,b) =>a+b;
    //   // publisher.myEvent += (a,b) =>
          publisher.myEvent += (
          sender ,e) =>

       {
    //     //    int c =a+b;
           int c =e.a+e.b;
         Console.WriteLine(c);

        };
        
    

    //     //invoke

    //     // publisher.RaiseEvent(10,20);
    //     // publisher.RaiseEvent(5,80);
    //     // publisher.RaiseEvent(14,22);
             publisher.RaiseEvent(this,10,20);
            publisher.RaiseEvent(this,5,80);
            publisher.RaiseEvent(this,14,22);

    
}
}