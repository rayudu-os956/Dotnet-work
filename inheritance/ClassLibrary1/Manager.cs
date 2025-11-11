public  class Manager : Employee
{
    //field
    private string _departmentName;
    //constructor 

    public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)
    {
        this._departmentName = departmentName;
    }
    //method hiding :SAME NAME  + SAME PARAMETERS (RETRUN TYPE MAY differ)
    public  override string GetHealthInsuranceAmount()
    {
        System.Console.WriteLine(base.GetHealthInsuranceAmount());
        return "Additional Health Insurance premium amount is:1000";
    }

    //property 
    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }

    //method

    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }
    public string GetFullDepartmentName()
    {
        return DepartmentName + "at" + base.Location;
    }
}

