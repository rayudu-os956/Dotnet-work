public class Salesman: IPerson,IEmployee
{
    private string _region;
        private System.DateTime _dateOfBirth;
    //constructor
    public Salesman(int empID, string empName, string location, string region) 
    {
        this._region = region;
    }
//method overriding abstract classes 
    public string GetHealthInsuranceAmount()
    {
        //System.Console.WriteLine(base.GetHealthInsuranceAmount());
        return "Additional Health Insurance premium amount is: 500";
    }
    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
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
       public int GetAge()
    {
       int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays/365);
       return a ;
    }

    //
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }


}