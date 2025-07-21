
Console.WriteLine("How many total subjects:");
int num = int.Parse(Console.ReadLine());

List<int> marks = new List<int>();


for (int a = 1; a<= num; a++)
{
    Console.WriteLine("Enter marks (0-100)");
    int mark = int.Parse(Console.ReadLine());
    marks.Add(mark);

}



int total_marks = 0;

foreach (int mark in marks)
{
    total_marks += mark;
}

double  avg_marks = ((double) total_marks / num*100)/100 ;

Console.WriteLine($"Your Total marks are {total_marks}");
Console.WriteLine($"You avg total is {avg_marks}");



char grade;
if (avg_marks >= 90) grade = 'A';
else if (avg_marks >= 80) grade = 'B';
else if (avg_marks >= 70) grade = 'C';
else if (avg_marks >= 60) grade = 'D';
else if (avg_marks >= 50) grade = 'E';
else grade = 'F';

switch (grade)
{
    case 'A': Console.WriteLine("Excellent Work!");break;
    case 'B': Console.WriteLine("Great Job!"); break;
    case 'C': Console.WriteLine("Good Effort"); break;
    case 'D': Console.WriteLine("Keep Trying"); break;
    case 'E': Console.WriteLine("Pass, but needs improvement."); break;
    case 'F': Console.WriteLine("Fail. Better luck next time."); break;
}

/*
string result = "Pass";

if (marks >= 50)
    result = "Pass";
else
    result = "Fail";
*/

string result = (avg_marks >= 50) ? "PASS" : "FAIL";
Console.WriteLine($"Result : {result}");
