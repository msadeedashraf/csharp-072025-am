using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Example
{
    public class Person(string firstname, string lastname, DateOnly birthday)
    {

        public string First { get; } = firstname;
        public string Last { get; } = lastname;

        public DateOnly Birthday { get; } = birthday;

        public List<Pet> Pets { get; } = new();




        /*
         public string FirstName { get; set; }
         public string  LastName { get; set; }

         public Person(string firstName , string lastName)
         {
             FirstName = firstName;
             LastName = lastName;

         }
        */



    }

    public abstract class Pet(string firstname)
    {
        public string First { get; } = firstname;

        public abstract string Makenoise();
    }

    public class Cat(string firstname) : Pet(firstname)
    {

        public override string Makenoise() => "Meao Meao";
    }

    public class Dog(string firstname) : Pet(firstname)
    {

        public override string Makenoise() => "Bark";
    }



    /*
     //Without Inheritance
    public class Cat(string firstname)
    {
        public string First { get; } = firstname;


        //public string Meao() { return "Meao Meao"}
        public string Meao() => "Meao Meao";
    }

    public class Dog(string firstname)
    {
        public string First { get; } = firstname;


        public string Bark() => "Bark";

    }
    */





}
