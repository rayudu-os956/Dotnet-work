using System.Linq.Expressions;

class Program
{
    class Student
    {
        public int StudntId{get;set;}
        public string StudntName{get;set;}
        public int Age{get;set;}
    }
    static void Main()
    {
        Student s = new Student(){StudntId =100,StudntName ="MOOk",Age =15};
        //create expression tree with func 
        Expression<Func<Student,bool>> expression = st  => st.Age >12 &&st.Age<20;

        Func<Student,bool>myDelegate = expression.Compile();
        //Executon 
       bool result =  myDelegate.Invoke(s);
       Console.WriteLine("RayuduKing" + result);
    }
}