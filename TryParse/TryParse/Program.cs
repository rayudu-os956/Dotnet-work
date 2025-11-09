class Program
{
    static void Main()
    {
        string s;
        System.Console.WriteLine("Enter a number: ");
        s = System.Console.ReadLine();

        //tryparese
        bool b = int.TryParse(s, out int n);

        if (b == true)
        {
            System.Console.WriteLine("Conversion suceessful");
            System.Console.WriteLine(n);
        }
        else
        {
            System.Console.WriteLine("Conversion failed");
        }
    }
}