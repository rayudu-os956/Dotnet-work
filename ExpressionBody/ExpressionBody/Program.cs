using ClassLibrary1;

class Program
{
    static void Main()
    {
        Student student =new Student() {StudntName = "Mook"};

        Console.WriteLine(student.StudntName);
        Console.WriteLine(student.GetStudentNameLength());
    }
}