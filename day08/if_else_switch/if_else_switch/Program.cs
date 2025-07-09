using System.Diagnostics;

//Switch Statements

DateTime    currentDate = DateTime.Now;
Console.WriteLine(currentDate.ToString());

int myDay = (int)currentDate.DayOfWeek;

switch (myDay)
{
    case 0:
        Console.WriteLine("Today is Sunday");
        break;

    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break;
    case 6:
        Console.WriteLine("Today is Saturday");
        break;


}






//If else Statement
/*
int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
*/


//The else if Statement
/*
int time = 22;
if (time < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
*/


//Ternary Operator
/*
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
*/


//Boolean
/*
int myAge = 16;
int votingAge = 18;

if (myAge >= votingAge)
{
    Console.WriteLine("Old enough to vote!");
}
else
{
    Console.WriteLine("Not old enough to vote.");
}
*/

//Strings

//Special Characters
/*
string message = "I'm learning \"C#\".\nAnd enjoing it.\nMy Intructor is Sadeed\t\t\tat CBC.";
Console.WriteLine(message);
*/

//Access Strings

/*
string myName = "Jhon Doe";

int charPos = myName.IndexOf(' ');

Console.WriteLine(myName.Substring(charPos+1));
*/


/*
string myName = "Chris";

Console.WriteLine(myName.IndexOf('r'));
*/

/*

string myName = "Chris";

for (int i = 0; i < myName.Length; i++)
{

Console.WriteLine(myName[i]);
}

*/

//String Iterpoltion 
/*
string firstName = "John";
string lastName = "Doe";
//string name = $"Welcome to CBC!\n My Name is {firstName} {lastName} ";
string name = $"Welcome to CBC!\nMy Name is {firstName + ' ' + lastName} ";
Console.WriteLine(name);
*/

//String Concatenation

/*
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);
*/

/*
string firstName = "John ";
string lastName = "Doe";

string fullName = string.Concat(firstName, lastName);

Console.WriteLine(fullName);
*/

/*
int x = 10;
int y = 20;
int z = x + y;  // z will be 1020 (a string)
Console.WriteLine(z + "\n\n");



string x1 = "20";
string y1 = "20";
int z1 = Convert.ToInt32(x1) + Convert.ToInt32(y1);  // z will be 1020 (a string)

Console.WriteLine(z1);
*/

/*
string greeting = "Welcome to CBC!";

Console.WriteLine(greeting.Length);
Console.WriteLine(greeting.ToLower());
Console.WriteLine(greeting.ToUpper());
*/





// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
