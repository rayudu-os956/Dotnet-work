public class Salesman : Employee
{
    private string _region;
    //constructor
    public Salesman(int empID,string empName,string location,string region) : base (empID,empName,location)
    {
        this._region = region;
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