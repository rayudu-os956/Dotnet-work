public partial class Product
{
    public double GetTax()
    {
        double tax = Cost*10/100;
        return tax;
    }
}