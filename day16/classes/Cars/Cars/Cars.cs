using System;


namespace Cars
{
    internal class Cars
    {

        //Fields---Attributes---Properties
        public string color = "" ;
        public int speed ;
        public string make ="";
        public int year;
        public string model = "";

        //Contructor -- a special method that has a same name as our class name. 
        
        public Cars(string _color, int _speed , string _make, int _year , string _model)
        {
            color = _color ;
            speed = _speed ;
            make = _make ;
            year = _year ; 
            model = _model ;


        }

        /*
        //Example for creating a carobject that creates a same car all the time. 
        public Cars()
        {
            color = "Red";
            speed = 300;
            make = "Honda";
        }
        */
        
        
        //Method

        public void drive(string make)
        {

            Console.WriteLine($"Im driving {make}");


        }
        /*
        //Example-1
        public void drive()
        {

            Console.WriteLine("Im driving a car");


        }
        */
        //This class has 3 members
        //2 properties and 1 Method

    }
}
