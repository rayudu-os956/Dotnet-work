class Program
{
   static void Main()
    {
        MarksPrinter<GraduateStudnt>mp = new MarksPrinter<GraduateStudnt>();
        mp.stu = new GraduateStudnt(){Marks =80};
        mp.PrintMarks();
        
    }
}

    
