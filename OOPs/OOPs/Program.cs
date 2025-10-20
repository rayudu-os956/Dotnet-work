class Sample
{
    static void Main()
    {
        //create objects
        Product product1, product2, product3;

        //creating objects  
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;

        //initializw fields

        product1.productID = 1001;
        product1.productName = "mobile";
        product1.cost = 20000;
        product1.qunatityInStock = 1200;
        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.qunatityInStock = 3400;
        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.qunatityInStock = 800;

        //get values from fields
        System.Console.WriteLine("Product1:");
        System.Console.WriteLine("ProductId:" + product1.productID);
        System.Console.WriteLine("Product Name:" + product1.productName);
        System.Console.WriteLine("Product Cost:" + product1.cost);
        System.Console.WriteLine("Product Quantity:" + product1.qunatityInStock);

        System.Console.WriteLine("\nProduct2:");
        System.Console.WriteLine("ProductId:" + product2.productID);
        System.Console.WriteLine("Product Name:" + product2.productName);
        System.Console.WriteLine("Product Cost:" + product2.cost);
        System.Console.WriteLine("Product Quantity:" + product2.qunatityInStock);

        System.Console.WriteLine("\nProduct3:");
        System.Console.WriteLine("ProductId:" + product3.productID);
        System.Console.WriteLine("Product Name:" + product3.productName);
        System.Console.WriteLine("Product Cost:" + product3.cost);
        System.Console.WriteLine("Product Quantity:" + product3.qunatityInStock);

        int totalQuantity = product1.qunatityInStock + product2.qunatityInStock + product3.qunatityInStock;
        System.Console.WriteLine("Total Quantity:" + totalQuantity);
         Product highestCostProduct = product1;
        
        if (product2.cost > highestCostProduct.cost)
        {
            highestCostProduct = product2;
        }

        if (product3.cost > highestCostProduct.cost)
        {
            highestCostProduct = product3;
        }
        Console.WriteLine("\nProduct with the highest cost:");
        Console.WriteLine("Product ID: " + highestCostProduct.productID);
        Console.WriteLine("Product Name: " + highestCostProduct.productName);
        Console.WriteLine("Cost: " + highestCostProduct.cost);
        Console.WriteLine("Quantity in Stock: " + highestCostProduct.qunatityInStock);

        System.Console.WriteLine("Total no of Products:" + Product.TotalNoProducts);
        System.Console.WriteLine("Category  of Products:" + Product.CategoryName);

    }
}

