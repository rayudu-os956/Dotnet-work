using System;
class Program
{
    static void Main()
    {
        Marvel m = new Marvel("IRONMAN");
        Console.WriteLine(m.CharacterName);
        m.PrintCharacterName();
    }
}