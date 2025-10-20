public class Rayudu
{
    static void Main()
    {
        Employee.OrganizationName = "Rayudu Company";
        System.Console.WriteLine("********************************* " + Employee.OrganizationName + " *********************************");
        // i am using loofp for 5 employess 
         //loop that executes 5times for 5 employees
        for(int i  =0;i< 5; i++)
        {
            string employeeNumber;
            switch (i)
            {
                case 0: employeeNumber = "FIRST EMPLOYEE:"; break;
                case 1: employeeNumber = "SECOND EMPLOYEE:"; break;
                case 2: employeeNumber = "THIRD EMPLOYEE:"; break;
                case 3: employeeNumber = "FOURTH EMPLOYEE:"; break;
                case 4: employeeNumber = "FIFTH EMPLOYEE:"; break;
                case 5: employeeNumber = "SIXTH EMPLOYEE:"; break;
                default: employeeNumber = "OTHER EMPLOYEE:"; break;
            }
            System.Console.WriteLine(employeeNumber);

            //create an object for Employee class

            Employee emp = new Employee();

            System.Console.WriteLine("Employee ID:");
            emp.EmpID = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Employee Name:");
            emp.EmpName = System.Console.ReadLine();

            System.Console.WriteLine("Salary Per Hour:");
            emp.SalaryPerHour = int.Parse(System.Console.ReadLine());

          System.Console.Write("No. of Working Hours: ");
            emp.NoofWorkingHours = int.Parse(System.Console.ReadLine());

            emp.NetSalary = emp.NoofWorkingHours * emp.SalaryPerHour;

            //display Employee Details
            System.Console.WriteLine("\nDETAILS OF " + employeeNumber);
            System.Console.WriteLine("Employee ID: " + emp.EmpID);
            System.Console.WriteLine("Employee Name: " + emp.EmpName);
            System.Console.WriteLine("Salary per Hour: " + emp.SalaryPerHour);
            System.Console.WriteLine("No. of Working Hours: " + emp.NoofWorkingHours);
            System.Console.WriteLine("Net Salary: " + emp.NetSalary);
            System.Console.WriteLine("Type of Employee: " + Employee.TypeOfEmployee);
            System.Console.WriteLine("Department Name: " + emp.DepartmentName);
            
            System.Console.Write("Do you want to continue to next employee? Yes / No: ");
            
            string choice = System.Console.ReadLine();

            if (!(choice == "yes" || choice == "YES" || choice == "Yes" || choice == "y" || choice == "Y"))
            {
                break;
            }

            System.Console.WriteLine("-----------------------------------"); //Separator line


        }

        
    }
}