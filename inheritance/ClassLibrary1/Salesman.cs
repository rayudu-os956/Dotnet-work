public class Salesman : Employee
{
    private string _region;
    //constructor
    public Salesman(int empID,string empName,string location,string region) : base (empID,empName,location)
    {
        this._region = region;
    }
//method overriding abstract classes 
    public override string GetHealthInsuranceAmount()
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
    //
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}