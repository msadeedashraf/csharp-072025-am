// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number of students:");

int numStudents = int.Parse(Console.ReadLine());

int[] grades = new int[numStudents];

for (int i = 0; i < numStudents; i++)
{
    Console.WriteLine($"Enter the grades for sudent {i+1}");
    grades[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
int min = grades[0];
int max = grades[0];

foreach(int grade in grades)
{
    sum += grade;
    if(grade < min) min = grade;
    if (grade > max) max = grade;
}

double average = (double)sum / numStudents;

Console.WriteLine($"\n Average grade : {average:F2}");
Console.WriteLine($"Highest grade: {max}");
Console.WriteLine($"Lowest grade: {min}");

Console.WriteLine("All grades: ");
foreach(int grade in grades)
{
    Console.WriteLine(grade);
}
