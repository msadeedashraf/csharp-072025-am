// See https://aka.ms/new-console-template for more information
// Specify the data source.


//https://learn.microsoft.com/en-us/dotnet/csharp/linq/

int[] scores = [97, 92, 81, 60];

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81