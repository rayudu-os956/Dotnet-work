class Program
{
    static void Main()
    {
        double[] a = new double[5]{10,20,30,40,50};

        int n = Array.IndexOf(a,30);
        Console.WriteLine("30 is found at "+n);
    }
}