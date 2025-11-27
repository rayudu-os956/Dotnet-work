class Program
{
    static void Main()
    {
        int[] a = new int[] {10,20,20,40,50,60};
        Array.Clear(a,2,3);
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}