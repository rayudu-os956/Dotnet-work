using System.Xml.Serialization;
class Student
{
    public string  StudentName{get;set;}
    
}
class Progran
{
    static void Main()
    {
        dynamic x;
        x=100;
        x ="Hello";
        x = new Student(){StudentName = "Rayudu"};

        Console.WriteLine(x.StudentName as String);
    }
}