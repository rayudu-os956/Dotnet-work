namespace ClassLibrary1;

public class Student
{
    //private field 
    private string _studentName;

    public int GetStudentNameLength() => _studentName.Length;
    
    //public cnstructors

    public Student() => _studentName = "rayudu";

    //public properties

    public string StudntName
    {
        set => _studentName = value;
        get => _studentName;
    }

}
