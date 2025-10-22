class Sample
{
    static void Main()
    {
        //create objects
        Product product1, product2, product3;

        //creating objects  
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts()+1);
        product2 = new Product();
         Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts()+1);
        Product.TotalNoProducts++;
        product3 = new Product();
         Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts()+1);
        Product.TotalNoProducts++;

        //initializw fields

        product1.SetProductID(1001);
        product1.SetProductName("mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);
        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);
        //call methods

        product1.CaluclateTax();
        product2.CaluclateTax();
        product3.CaluclateTax();

        //get values from fields
        System.Console.WriteLine("Product1:");
        System.Console.WriteLine("ProductId:" + product1.GetProductID());
        System.Console.WriteLine("Product Name:" + product1.GetProducName());
        System.Console.WriteLine("Product Cost:" + product1.GetCost());
        System.Console.WriteLine("Product Quantity:" + product1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase:" + product1.GetDateOfPurchase());
        System.Console.WriteLine("Tax:" + product1.GetTax());

        System.Console.WriteLine("\nProduct2:");
        System.Console.WriteLine("ProductId:" + product2.GetProductID());
        System.Console.WriteLine("Product Name:" + product2.GetProducName());
        System.Console.WriteLine("Product Cost:" + product2.GetCost());
        System.Console.WriteLine("Product Quantity:" + product2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase:" + product2.GetDateOfPurchase());
        System.Console.WriteLine("Tax:" + product2.GetTax());

        System.Console.WriteLine("\nProduct3:");
        System.Console.WriteLine("ProductId:" + product3.GetProductID());
        System.Console.WriteLine("Product Name:" + product3.GetProducName());
        System.Console.WriteLine("Product Cost:" + product3.GetCost());
        System.Console.WriteLine("Product Quantity:" + product3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase:" + product3.GetDateOfPurchase());
        System.Console.WriteLine("Tax:" + product3.GetTax());

        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
       
        System.Console.WriteLine("Total Quantity:" + totalQuantity);
         Product highestCostProduct = product1;
        
        if (product2.GetCost() > highestCostProduct.GetCost())
        {
            highestCostProduct = product2;
        }

        if (product3.GetCost() > highestCostProduct.GetCost())
        {
            highestCostProduct = product3;
        }
        Console.WriteLine("\nProduct with the highest cost:");
        Console.WriteLine("Product ID: " + highestCostProduct.GetProductID());
        Console.WriteLine("Product Name: " + highestCostProduct.GetProducName());
        Console.WriteLine("Cost: " + highestCostProduct.GetCost());
        Console.WriteLine("Quantity in Stock: " + highestCostProduct.GetQuantityInStock());

        System.Console.WriteLine("Total no of Products:" + Product.GetTotalNoOfProducts());
        System.Console.WriteLine("Category  of Products:" + Product.CategoryName);

    }
}

