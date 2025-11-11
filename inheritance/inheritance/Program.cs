class Program
{
    static void Main()
    {
        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.EmpName = "Rayudu";
        emp1.Location = "Hyderabad";
        System.Console.WriteLine("Object of Parent class");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Location);

        //create bject for manager

        Manager mgr1 = new Manager();
        mgr1.EmpID = 102;
        mgr1.EmpName = "Mook";
        mgr1.Location = "Bangkok";
        mgr1.DepartmentName = "Accounting";

        System.Console.WriteLine("Object of child class(manager)");
        System.Console.WriteLine(mgr1.EmpID);
        System.Console.WriteLine(mgr1.EmpName);
        System.Console.WriteLine(mgr1.Location);
        System.Console.WriteLine(mgr1.DepartmentName);
        System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine(mgr1.GetFullDepartmentName());


    //object for slaesman

        Salesman salesman1 = new Salesman();
        salesman1.EmpID = 103;
        salesman1.EmpName = "Dory";
        salesman1.Location = "Bejing";
        salesman1.Region = "East";

        System.Console.WriteLine("Object of child class(salesman)");
        System.Console.WriteLine(salesman1.EmpID);
        System.Console.WriteLine(salesman1.EmpName);
        System.Console.WriteLine(salesman1.Location);
        System.Console.WriteLine(salesman1.Region);
        System.Console.WriteLine(salesman1.GetSalesOfTheCurrentMonth());



    }
}