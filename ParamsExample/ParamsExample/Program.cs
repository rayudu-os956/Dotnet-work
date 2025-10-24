class Student
{
    public void DisplaySubjects(params string[] subjcets)
    {
        for(int i=0;i<subjcets.Length;i++)
        {
            System.Console.WriteLine(subjcets[i]);
        }

    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics", "Digital system Desgin","Basics of c");

    }
}