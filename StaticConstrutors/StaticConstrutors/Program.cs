class Program
{
    static  void Main()
    {
        //creaTE THREE OBJECTS FOR EMPLOYEE 

        Employee emp1 = new Employee();//constructor3
        emp1.empID = 101;
        emp1.empName = "Rayudu";
        emp1.job = "Manager";
        Employee emp2 = new Employee(102, "Mook");//constructor2
        emp2.job = "Asst.Manager";
        Employee emp3 = new Employee(103, "Dory", "Clerk");//constructor1
        Employee emp4 = new Employee() {empName ="Maanoj",job ="Executive"};

        //display fields 
        System.Console.WriteLine(Employee.companyName);
        System.Console.WriteLine("\nFirst Employee:");
        System.Console.WriteLine(emp1.empID);
        System.Console.WriteLine(emp1.empName);
        System.Console.WriteLine(emp1.job);
        
        System.Console.WriteLine("Second Employee:");
        System.Console.WriteLine(emp2.empID);
        System.Console.WriteLine(emp2.empName);
        System.Console.WriteLine(emp2.job);

        System.Console.WriteLine("third Employee:");
        System.Console.WriteLine(emp3.empID);
        System.Console.WriteLine(emp3.empName);
        System.Console.WriteLine(emp3.job);
              
         System.Console.WriteLine("Fourt Employee:");
        System.Console.WriteLine(emp4.empID);
        System.Console.WriteLine(emp4.empName);
        System.Console.WriteLine(emp4.job);


        
    }
}