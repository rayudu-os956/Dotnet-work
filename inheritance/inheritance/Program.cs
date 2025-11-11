class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101,"Rayudu","Hyderbad");

        System.Console.WriteLine("Object of Parent class");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Location);

        //create bject for manager

        Manager mgr1 = new Manager(102,"Mook","Bangkok","Accounting");
 
        System.Console.WriteLine("Object of child class(manager)");
        System.Console.WriteLine(mgr1.EmpID);
        System.Console.WriteLine(mgr1.EmpName);
        System.Console.WriteLine(mgr1.Location);
        System.Console.WriteLine(mgr1.DepartmentName);
        System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine(mgr1.GetFullDepartmentName());


    //object for slaesman

        Salesman salesman1 = new Salesman(103,"Dory","Bejing","East");

        System.Console.WriteLine("Object of child class(salesman)");
        System.Console.WriteLine(salesman1.EmpID);
        System.Console.WriteLine(salesman1.EmpName);
        System.Console.WriteLine(salesman1.Location);
        System.Console.WriteLine(salesman1.Region);
        System.Console.WriteLine(salesman1.GetSalesOfTheCurrentMonth());



    }
}