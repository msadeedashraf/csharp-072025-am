namespace Properties_example
{
    internal class Program
    {



        static void Main(string[] arg)
        {
            Car Honda = new Car(2025) { Speed = 180} ;
            
            Honda.Model = "CRV";
            Honda.Color = "Red";
            
            Console.WriteLine($"Im driving {Honda.Model} and its a {Honda.Year}, color is {Honda.Color} the max speed is {Honda.Speed}");


            Car Toyota = new Car(2022) { Speed = 170};

            Toyota.Model = "RAV4";
            Toyota.Color = "Black";

            Console.WriteLine($"Im driving {Toyota.Model} and its a {Toyota.Year}, color is {Toyota.Color}, the max speed is {Toyota.Speed}");


            Car BMW = new Car(2023){ Model="C",Color="Black" ,Speed= 230 };

            
            Console.WriteLine($"Im driving {BMW.Model} and its a {BMW.Year}, color is {BMW.Color} the max speed is {BMW.Speed}");


            /*
            //Example-2
            Car Ford = new Car("Mustang");
            Ford.Model = "Abc";
            Console.WriteLine(Ford.Model);
            */


            /*
             //Example-1
            Car Ford = new Car("Mustang", 200,2025,"Blue");
            Console.WriteLine(Ford.model);
            Ford.year = 2024;
            Console.WriteLine(Ford.year);


            Car Honda = new Car("CRV", 180, 2022, "Red");
            Console.WriteLine(Honda.model);

            Car Toyota= new Car("RAV4", 170, 2023, "Black");
            Console.WriteLine(Toyota.model);
            */

        }




    }



    class Car
    {
        //Automatic Properties(Short Hand)
        public string Model { get; set; }
        //public int Year { get; init; } = 2020;
        public int Year { get;} 
        public int Speed { get; set; }
        public string Color { get; set; }


        public Car(int year) 
        {
            Year = year;
        }

        /*
         //Example-2
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car(string _model)
        {
            model = _model;
        }
        */


        /*
         //Example-1
        public string model;  // Create a field
        public int speed;
        public int year;
        public string color;

        

        // Create a class constructor for the Car class
        public Car( string _model , int _speed, int _year, string _color)
        {
            //model = "Mustang"; // Set the initial value for model
            model = _model;
            speed = _speed;
            year = _year;
            color = _color;


        }
        */

    }


}