public class Salesman:IEmployee
{
    private string _region;
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

    public int EmpID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string EmpName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}