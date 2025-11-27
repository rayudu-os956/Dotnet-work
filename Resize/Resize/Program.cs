class Program
{
    static void Main()
    {
        int[] a = new int[] {10,20,20};
        Array.Resize(ref a,2);

        foreach(var item in a)
        {
            Console.WriteLine(item);
        }
    }
}