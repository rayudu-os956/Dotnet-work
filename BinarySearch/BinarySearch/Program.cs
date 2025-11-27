class Program
{
    static void Main()
    {
        double[] a = new double[]{10,20,30,40,50,60,70,80,90,100};

        int n = Array.BinarySearch(a,30);
        Console.WriteLine("30 is found at "+n);
        //search for 30 in the array 

        int n2 = Array.BinarySearch(a,80);
          Console.WriteLine("100 is found at "+n2);


    }
}