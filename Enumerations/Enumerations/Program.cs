using System;

class Program
{
    static void Main()
    {
        Person person  = new Person();
        person.PersonName = "John";
        person.Email = "jask@gmail.copm";
        person.AgeGroup = AgeGroupEnumeration.Adult;
        Console.WriteLine(person.AgeGroup);

        }
}