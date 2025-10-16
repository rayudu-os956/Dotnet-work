class program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                if (j == 5 || j == 6)
                {
                    continue;
                }
                System.Console.WriteLine(j + " ");
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 10; j >= 1; j--)
            {
                if (i == 2) //line 6
                {
                    //skip numbers 2 and 1 in line 6
                    if (j == 2 || j == 1)
                    {
                        continue;
                    }
                }

                if (i == 4) //line 8
                {
                    //skip output '8' in line 8
                    if (j == 3)
                    {
                        continue;
                    }
                    System.Console.Write((11 - j) + " ");
                    continue;
                }
                 System.Console.Write(j + " ");
            }

        }
    }
}
  