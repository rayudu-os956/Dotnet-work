using ClassLibrary1;

class Program
{
    static void Main()
    {
        ClassLibrary1.MarksCalculation.CalucaltionJelper ch = new ClassLibrary1.MarksCalculation.CalucaltionJelper();
        
        Console.WriteLine(ch.Multiply(10,5));
        ClassLibrary1.MarksCalculation mc = new ClassLibrary1.MarksCalculation();
        Student s = new Student(){SecuredMarks =36, MaxMarks =50};
        mc.CalculatePercentage(s);
        Console.WriteLine(s.Percentage);
    }
}