namespace ClassLibrary1;

public class Student
{
    public double SecuredMarks;
    public double MaxMarks;
    public double Percentage;
}
//outer class
public class MarksCalculation
{
    public void CalculatePercentage(Student s)
    {
        CalucaltionJelper ch = new CalucaltionJelper();
        s.Percentage = ch.Multiply(s.SecuredMarks/s.MaxMarks,100);
    }
    //inner class 
    public class CalucaltionJelper
    {
        public double Multiply(double n1,double n2)
        {
            return n1*n2;
        }
    }
}
