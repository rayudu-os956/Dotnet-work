class Program
{
    static void Main()
    {
        double[] a = new double[6]{10,20,30,40,50,30};

        int n = Array.IndexOf(a,30);
        Console.WriteLine("30 is found at "+n);
        //search for 30 in the array 

        int n2 = Array.IndexOf(a,30,3);
          Console.WriteLine("30 is found at "+n2);
    }
}