using System.ComponentModel.Design.Serialization;

public class Employee
{
    public int EmpID;
    public string EmpName;

    public int SalaryPerHour;

    public int NoofWorkingHours;

    public int NetSalary;

    public static string OrganizationName;

    public const string TypeOfEmployee = "Contract based";

    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Finance Department;";
    }


}