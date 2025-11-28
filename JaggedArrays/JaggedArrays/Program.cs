class Program
{
    static void Main()
    {
       int[][]  a = new int[5][];
       a[0] = new int[3] {10,20,30};
       a[1] = new int[5] {40,30,60,70,80}; 
       a[2] = new int[2] {90,100}; 
       a[3] = new int[4] {110,120,130,140}; 
       a[4] = new int[8] {4150,160,170,180,190,200,210,220}; 
       for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

  
    
}