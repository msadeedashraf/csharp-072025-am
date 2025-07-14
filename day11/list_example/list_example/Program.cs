// See https://aka.ms/new-console-template for more information
//List
//https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection

/*
List<string> names = ["Sadeed", "Amber", "Ruth"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}");
}
*/


/*
List<string> students = new List<string>();

students = ["Sadeed", "Adwin", "Chris"];


foreach(var student in students)
{
    Console.WriteLine($"Hello {student}");
}

*/

//List<string> students = new List<string>();

var students = new List<string> { "CJ", "Done", "Ruth", "Shalah" , "Anurag", "Edwin"};


/*
for(int i=0; i < students.Count; i++)
{
    Console.WriteLine($"Hello {students[i]}");
}
*/

students.Add("Thiom");

students.Remove("Edwin");

students.Sort();


foreach(var student in students)
{
    Console.WriteLine($"Hello {student.ToUpper()}");
}




