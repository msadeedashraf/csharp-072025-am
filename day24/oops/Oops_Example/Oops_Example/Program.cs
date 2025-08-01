//Change the name of the namespace to your project name
using Oops_Example;

namespace Oops_Example
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            var p1 = new Person("Chris", "David", new DateOnly(1990, 1, 1));
            var p2 = new Person("Sarah", "William", new DateOnly(2010, 1, 1));

            p1.Pets.Add(new Dog("Tom"));
            p1.Pets.Add(new Cat("SadEye"));

            p2.Pets.Add(new Dog("Barney"));





            List<Person> people = [p1, p2];

            foreach(var p in people)
            {

                Console.WriteLine($"{p.First} {p.Last}");

                foreach(var pet in p.Pets)
                {
                    Console.WriteLine($"      {pet.First}");
                }


            }


            //Console.WriteLine(people.Count);
        }

    }
}



