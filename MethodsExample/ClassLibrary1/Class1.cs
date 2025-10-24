using System.ComponentModel.Design.Serialization;

public class Product
{
    //fields

    private int productID;
    private string productName;
    private double cost;

    private double tax;
    private int qunatityInStock;

    public static int TotalNoProducts;

    public const string CategoryName = "Electronics ";
    private readonly string dateOfPurchase;

    //constructor

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
    //set  
    public void SetProductID(int productID)
    {
        this.productID = productID;

    }
    //get 
    public int GetProductID()
    {
        return productID;
    }
        //set  
    public void SetProductName(string value)
    {
        productName = value;

    }
    //get 
    public string GetProducName()
    {
        return productName;
    }
            //set  
    public void SetCost(double value)
    {
        cost = value;

    }
    //get 
    public double GetCost()
    {
        return cost;
    }

                //set  
    public void SetTax(double value)
    {
        tax = value;

    }
    //get 
    public double GetTax()
    {
        return tax;
    }

     //set  
    public void SetQuantityInStock(int value)
    {
        qunatityInStock = value;

    }
    //get 
    public int GetQuantityInStock()
    {
        return qunatityInStock;
    }

    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    //method 
    //cost<=2000 then tax =10%
    //cost >2000 then tax =12.5%

    public void CaluclateTax(double percentage = 4.5)
    {
        double t;

        //clauclate tax 
        if (cost <= 20000)
        {
            t = cost * 10/ 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }
    public void CaluclateTax(double cost, double percentage)
    {
         double t;

        //clauclate tax 
        if (cost <= 50000)
        {
            t = cost * 5 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }  
    
    //static metythods
    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }
    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }
    //caluclate Total Quantity

    public static int GetTotalQuantity( Product product1, Product product2,Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }

}

