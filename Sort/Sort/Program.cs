class Program
{
    static void Main()
    {
        int[] a = new int[]{56,98,65,5,4,100,900,124};
        Array.Sort(a);
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}