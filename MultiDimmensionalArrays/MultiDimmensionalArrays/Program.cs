class Program
{
    static void Main()
    {
        int[,] a = new int[4, 3]
        {
            {1,2,3},
            {140,23,34},
            {51,62,53},
            {54,98,76}

        };
        for (int i = 0; i < 4; i++)
        {
            for(int j=0; j < 3; j++)
            {
                Console.Write(a[i,j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}