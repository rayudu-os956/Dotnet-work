class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[]
        {
            new Employee(){EmployeeName="Rayudu",Role = "Developer"},
            new Employee(){EmployeeName="Mook",Role = "Designer"},
            new Employee(){EmployeeName = "Dory",Role = "Analyst"}
        };
        //new array 
        Employee[]highlyPaidEmployees=new Employee[5];
        employees.CopyTo(highlyPaidEmployees,2);
          Console.WriteLine("Cpy:");
        foreach (Employee emp in highlyPaidEmployees)
        {
            if(!(emp is null))
            {
                Console.WriteLine(emp.EmployeeName+"," +emp.Role); 
            }
            else
            {
                 Console.WriteLine("Null exception");
            }
           
        }

        //clone
       Employee[] highlyPaidEmployees2 =  (Employee[])employees.Clone();
       Console.WriteLine("\nClone:");
       foreach(Employee emp in highlyPaidEmployees2)
        {

            if(!(emp is null))
            {
                Console.WriteLine(emp.EmployeeName+"," +emp.Role); 
            }
            else
            {
                 Console.WriteLine("Null exception");
            }
        }
    }
}
class Employee
{
    public string EmployeeName{get;set;}
    public string Role {get;set;}
}