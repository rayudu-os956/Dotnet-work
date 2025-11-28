using ClassLibrary1;

class Program
{
    static void Main()
    {


        Employee[] employees = new Employee[]
        {
        new Employee(){empId = 101 , EmpName = "Rayudu"},
        new Employee(){empId = 102 , EmpName = "Mook"},
        new Employee(){empId = 103 , EmpName = "Dory"},
        };
        foreach(Employee item in employees)
        {
            Console.WriteLine(item.empId + " ," + item.EmpName);
        }

    }
}