class Program
{
    static  void Main()
    {
        //creaTE THREE OBJECTS FOR EMPLOYEE 

        Employee emp1 = new Employee();//constructor3
        emp1.EmpID = 101;
        emp1.EmpName = "Rayudu";
        emp1.Job = "Manager";
        emp1.Tax = 50;
        emp1.NativePlace = "New Delhi";
        Employee emp2 = new Employee(102, "Mook");//constructor2
        emp2.Job = "Asst.Manager";
        Employee emp3 = new Employee(103, "Dory", "Clerk");//constructor1
        Employee emp4 = new Employee() {EmpName ="Maanoj",Job ="Executive"};

        //display fields 
        System.Console.WriteLine(Employee.CompanyName);
        System.Console.WriteLine("\nFirst Employee:");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Job);
        System.Console.WriteLine(emp1.Salary);
        System.Console.WriteLine(emp1.CaluclateNetSalary());
        System.Console.WriteLine(emp1.NativePlace);
         
         
        
        System.Console.WriteLine("Second Employee:");
        System.Console.WriteLine(emp2.EmpID);
        System.Console.WriteLine(emp2.EmpName);
        System.Console.WriteLine(emp2.Job);
            System.Console.WriteLine(emp2.Salary);

        System.Console.WriteLine("third Employee:");
        System.Console.WriteLine(emp3.EmpID);
        System.Console.WriteLine(emp3.EmpName);
        System.Console.WriteLine(emp3.Job);
            System.Console.WriteLine(emp3.Salary);
              
         System.Console.WriteLine("Fourt Employee:");
        System.Console.WriteLine(emp4.EmpID);
        System.Console.WriteLine(emp4.EmpName);
        System.Console.WriteLine(emp4.Job);
        System.Console.WriteLine(emp4.Salary);


        
    }
}