public abstract class Student
{
    public abstract int Marks{get;set;}
}
public class GraduateStudnt : Student
{
    public override int Marks{get;set;}
}
public class PostGraduteStudnt : Student
{
    public override int Marks{get;set;}
    
}
//generic classes 
public class MarksPrinter<T> where T: Student 
{
    public T stu;

    public void PrintMarks()
    {
        Student temp = (Student)stu;
        Console.WriteLine(temp.Marks);

    }

}