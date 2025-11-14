public  class Manager: IPerson,IEmployee
{
    //field
    private string _departmentName;
    private System.DateTime _dateOfBirth;
    //constructor 

    public Manager(int empID, string empName, string location, string departmentName) 
    {
        this._departmentName = departmentName;
    }
    //method hiding :SAME NAME  + SAME PARAMETERS (RETRUN TYPE MAY differ)
    //method overriding the abstract methods
    public   string GetHealthInsuranceAmount()
    {
        //System.Console.WriteLine(base.GetHealthInsuranceAmount());
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
    public System.DateTime DateOfBirth
    {
        set
        {
            _dateOfBirth =value;
        }
        get
        {
            return _dateOfBirth;
        }
    }

    public int EmpID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string EmpName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //method

    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }
    public string GetFullDepartmentName()
    {
        return DepartmentName ;
    }

     int IPerson.GetAge()
    {
       int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays/365);
       return a ;
    }
    int IEmployee.GetAge()
    {
            
       return 20 ;
    }
}

