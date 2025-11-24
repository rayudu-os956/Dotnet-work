using ClassLibrary1;

class Program
{
    static void Main()
    {
       Sample s = new Sample();

        Mydelegate mydelegate;

        mydelegate = s.Add;

        //2m

        mydelegate += s.Multiply;
        mydelegate.Invoke(40,10);
    }
}
