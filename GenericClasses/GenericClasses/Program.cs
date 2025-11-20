class Program
{
    static void Main()
    {
        //create object for generic class
        User<int,int>user1 = new User<int,int>();
        User<bool,string>user2 = new User<bool,string>();

        //set value for generic class
        user1.ResgitrationStatus =1234;
        user2.ResgitrationStatus =false;

        user1.Age =22;
        user2.Age = "35-40";
        Console.WriteLine(user1.ResgitrationStatus);
        Console.WriteLine(user2.ResgitrationStatus);
        Console.WriteLine(user1.Age);
        Console.WriteLine(user2.Age);
    }
}