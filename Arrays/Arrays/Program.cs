class Program
{
    static void Main()
    {
        int[] a = new int[5] {10,20,30,40,50};
        string[] b = new string[5]{"rayudu","mook","dory","cordy","manoj"};
        foreach (int i in a )
        {
            Console.WriteLine(i);
        }
        foreach (string i in b)
        {
            Console.WriteLine(i);
        }
       
      
    }
}