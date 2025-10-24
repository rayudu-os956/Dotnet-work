class Student
{
    public int grade = 2;
    public void PrintGrade()
    {
        System.Console.WriteLine("Grade:" + grade);
    }
    
    public ref int DoWork()
    {
        return ref grade;
    }

}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.PrintGrade();
        //call Do Wrork
        ref int g = ref s.DoWork();
        //update the value of 'ref return'
        g = 5;
        //call print after updating value of 'ref return'
        s.PrintGrade();
        
    }
}