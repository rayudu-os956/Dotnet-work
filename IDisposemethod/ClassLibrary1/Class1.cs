namespace ClassLibrary1;

public class Sample:System.IDisposable
{
//
public Sample()
    {
        Console.WriteLine("Databse conected");
    }
    //method 
    public void DisplayData()
    {
        Console.WriteLine("ReadingData from database");
    }

    //dispose method 
    public void Dispose()
    {
        Console.WriteLine("data base connected ");
    }

}
