class Program
{
    static void Main()
    {
        int operation =10;
        string result;
        //switch expression

        result = operation switch
        {
            1 => "Customer",
            2 => "student",
            3 => "employee",
            4 => "supplier",
             _=> "No case avaialiable"

        };
        Console.WriteLine(result);
    }
}