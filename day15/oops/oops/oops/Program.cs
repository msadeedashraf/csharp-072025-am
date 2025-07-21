// See https://aka.ms/new-console-template for more information
using System;

Person p1 = new Person("Sadeed", "Ashraf", 10, DateOnly.Parse("2000/12/01"));
Person p2 = new Person("Anurag", "Sharma", 20, DateOnly.Parse("2010/12/01"));

Console.WriteLine($"My Name is  {p1.firstName} {p1.lastName}." +
                  $"\n My Age is {p1.age}. " +
                  $"\n My DOB is {p1.dob}");

Console.WriteLine($"My Name is {p2.firstName} {p2.lastName}." +
                  $"\n My Age is {p2.age}. " +
                  $"\n My DOB is {p2.dob}");

/*
Person p1 = new Person() 
            { 
              firstName = "Sadeed", 2
              lastName = "Ashraf", 
              age = 10, 
              dob = DateOnly.Parse("2000/12/01") 
            };

Console.WriteLine($"My Name is {p1.firstName} {p1.lastName}." +
                  $"\n My Age is {p1.age}. " +
                  $"\n My DOB is {p1.dob}");

*/

/*
Person p1 = new Person();

p1.firstName = "Sadeed";
p1.lastName = "Ashraf";
p1.age = 10;
p1.dob = DateOnly.Parse("2000/12/01");

Console.WriteLine($"My Name is {p1.firstName} {p1.lastName}." +
                  $"\n My Age is {p1.age}. " +
                  $"\n My DOB is {p1.dob}");





Person p2 = new Person();

p2.firstName = "Anurag";
p2.lastName = "Sharma";
p2.age = 20;
p2.dob = DateOnly.Parse("2010/12/01");

Console.WriteLine($"My Name is {p2.firstName} {p2.lastName}." +
                  $"\n My Age is {p2.age}. " +
                  $"\n My DOB is {p2.dob}");

*/

public class Person
{
    //Constructor
    public Person(string _firstName, string _lastName , int _age , DateOnly _dob)
    {
        firstName = _firstName;
        lastName = _lastName;
        age = _age;
        dob = _dob;

    }

    public string firstName;
    public string lastName;
    public int age;
    public DateOnly dob;



}


