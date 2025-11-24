using ClassLibrary1;

class Program
{
    static void Main()
    {
        Sample s = new Sample();

        //create a delegate 
        MyDelegateType myDelegate;
        
        //add method refernce to object 

       myDelegate =  new MyDelegateType(s.Add);
       //invoke usinf delegate object 
       Console.WriteLine(myDelegate.Invoke(30,40));
       
    }
}