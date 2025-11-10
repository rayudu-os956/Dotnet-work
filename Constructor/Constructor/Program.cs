class Program
{
    static  void Main()
    {
        //creaTE THREE OBJECTS FOR EMPLOYEE 

        Employee emp1 = new Employee(101,"Rayudu","Manager");
        Employee emp2 = new Employee(102,"Mook","Tester");
        Employee emp3 = new Employee(103,"Dory", "Clerk");

        //display fields 

        System.Console.WriteLine("First Employee:");
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

        
    }
}