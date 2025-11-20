class Program
{
    static void Main()
    {
        //create object for generic class
        User<int>user1 = new User<int>();
        User<bool>user2 = new User<bool>();

        //set value for generic class
        user1.ResgitrationStatus =1234;
        user2.ResgitrationStatus =false;
        Console.WriteLine(user1.ResgitrationStatus);
        Console.WriteLine(user2.ResgitrationStatus);
    }
}