using ClassLibrary1;

class Program
{
    static void main()
    {
        using(Sample s = new Sample())
        {
            s.DisplayData();
        }
        Console.WriteLine("smaple work");
    }
}