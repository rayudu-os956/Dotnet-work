public class Employee
{
    //fieldsw

    public int empID;
    public string empName;

    public string job;
    //static field 
    public static string companyName;
    //constructor1

    public Employee(int empID, string empName, string job)
    {
        this.empID = empID;
        this.empName = empName;
        this.job = job;
    }

    //constructor overloding 

        //constructor2
    public Employee(int empID, string empName)
    {
        this.empID = empID;
        this.empName = empName;
    }
        //constructor3
    public Employee()
    {
        empID = 1;
    }
    //static constructor
    static Employee()
    {
        companyName = "Ray Industries";

    }
}