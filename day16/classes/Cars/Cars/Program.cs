using System;


namespace Cars
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            //Refactor Exampele -- 2
            //Contructors //https://www.w3schools.com/cs/cs_constructors.php
            Cars myCarObj1 = new Cars("Blue", 100, "Honda", 2025, "CRV");

            myCarObj1.drive(myCarObj1.make);
            Console.WriteLine($"\n and its a {myCarObj1.year} {myCarObj1.model}");
            Console.WriteLine($"My Car is {myCarObj1.color} and has a max speed of {myCarObj1.speed}");




            Cars myCarObj2 = new Cars("Red", 200, "BMW",2020,"300");

            myCarObj2.drive(myCarObj2.make);
            Console.WriteLine($"\n and its a {myCarObj2.year} {myCarObj2.model}");
            Console.WriteLine($"My Car is {myCarObj2.color} and has a max speed of {myCarObj2.speed}");


            Cars myCarObj3 = new Cars("Yellow", 250, "Ford",2022, "Escape");

            myCarObj3.drive(myCarObj3.make);
            Console.WriteLine($"\n and its a {myCarObj3.year} {myCarObj3.model}");
            Console.WriteLine($"My Car is {myCarObj3.color} and has a max speed of {myCarObj3.speed}");



            /*
            ////Example for creating a carobject that creates a same car all the time. 
            Cars myCarObj1 = new Cars();

            myCarObj1.drive(myCarObj1.make);
            Console.WriteLine($"My Car is {myCarObj1.color} and has a max speed of {myCarObj1.speed}");
            */


            /*
            //Example -2 
            Cars myCarObj1 = new Cars();

            myCarObj1.speed = 150;
            myCarObj1.color = "Silver";
            myCarObj1.make = "Honda";

            myCarObj1.drive(myCarObj1.make);

            Console.WriteLine($"My Car is {myCarObj1.color} and has a max speed of {myCarObj1.speed}");

            Cars myCarObj2 = new Cars();

            myCarObj2.speed = 200;
            myCarObj2.color = "Black";
            myCarObj2.make = "BMW";

            myCarObj2.drive(myCarObj2.make);

            Console.WriteLine($"My Car is {myCarObj2.color} and has a max speed of {myCarObj2.speed}");

            */



            /* Example 1*/
            /*
            Cars honda = new Cars();

            honda.color = "Black";
            honda.speed = 200;


            Console.WriteLine($"My Car is {honda.color} and has a max speed of {honda.speed}");

            honda.drive();


            Cars bmw = new Cars();

            bmw.color = "Blue";
            bmw.speed = 250;


            Console.WriteLine($"My Car is {bmw.color} and has a max speed of {bmw.speed}");

            bmw.drive();
            */



        }

    }


}


/*
 namespace Cars
{
    internal class Program
    {

        static void Main(string[] arg)
        {

        }

    }


}*/

