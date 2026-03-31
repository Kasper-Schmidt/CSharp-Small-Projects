// true false in one line
int c = 8, d = 10;
Console.WriteLine(c > d ? "a is greater than b" : "b is greater than a");



Console.WriteLine("");
Console.WriteLine("1--------------------------------------------------");
Console.WriteLine("");








// ----- Lists -----
var names = new List<string> { "Kasper", "Maja", "Jake", "Viggo" };

names.Add("Anders");
names.Add("Mads");
names.Add("Marianne");


foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}


Console.WriteLine("");
Console.WriteLine("2--------------------------------------------------");
Console.WriteLine("");


foreach (var name in names[2..4]) // 2 er inclusive og 4 er exclusive, så det bliver kun indeks 2 og 3.
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}




Console.WriteLine("");
Console.WriteLine("3--------------------------------------------------");
Console.WriteLine("");



Console.WriteLine(names[0]);
Console.WriteLine(names[2]);

Console.WriteLine(names[names.Count-1]); // count = 6 - 1 = 5, så index 5 = Marianne
Console.WriteLine(names[^1]); // placering 1 bagfra = Marianne
Console.WriteLine(names[^3]); // placering 3 bagfra = Anders



Console.WriteLine("");
Console.WriteLine("4--------------------------------------------------");
Console.WriteLine("");









// ----- Array -----

var cars = new string[] { "Ford", "Skoda", "Ferrari", "Pagani" };

cars = cars.Append("Lamborghini").ToArray(); // Append returnerer en ny array, så det ændrer ikke på den originale array.
cars = [..cars, "Bugatti"]; // Dette er en ny syntax i C# 13, som gør det nemmere at tilføje elementer til en array. Det er det samme som cars = cars.Append("Bugatti").ToArray();]

foreach (var car in cars)
{
    Console.WriteLine($"Hello {car.ToUpper()}");
}




Console.WriteLine("");
Console.WriteLine("5--------------------------------------------------");
Console.WriteLine("");




// ----- Sort -----

var watches = new List<string> { "Rolex", "Patek Philippe", "Audemars Piguet", "Richard Mille" };

watches.Sort();

foreach (var watch in watches)
{
    Console.WriteLine($"Hello {watch.ToUpper()}");
}


Console.WriteLine("");
Console.WriteLine("6--------------------------------------------------");
Console.WriteLine("");



var numbers = new List<int> { 45, 23 , 89, 18 };

numbers.Sort();

foreach (var number in numbers)
{
    Console.WriteLine($"Score: {number}");
}



Console.WriteLine("");
Console.WriteLine("7--------------------------------------------------");
Console.WriteLine("");






// ----- LINQ: Language Integrated Query -----

List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];

// Uden LINQ måde:
for (int i = 0; i < scores.Count; i++)
{
    if (scores[i] > 80)
    {
        Console.WriteLine($"Score over 80, it is: {scores[i]}");
    }
}



Console.WriteLine("");
Console.WriteLine("8--------------------------------------------------");
Console.WriteLine("");



// LINQ måde:
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

foreach (int i in scoreQuery)
{
    Console.Write($"{i} is over 80\n");
}




Console.WriteLine("");
Console.WriteLine("9--------------------------------------------------");
Console.WriteLine("");







// ----- LINQ Query Expressions ----- 
// orderby

IEnumerable<int> scoreQuery1 =
    from score in scores
    where score > 80
    orderby score descending
    select score;

foreach (int i in scoreQuery1)
{
    Console.Write($"{i}\n");
}



Console.WriteLine("");
Console.WriteLine("10--------------------------------------------------");
Console.WriteLine("");





IEnumerable<string> scoreQuery2 =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";


foreach (string s in scoreQuery2)
{
    Console.WriteLine(s);
}


Console.WriteLine("");
Console.WriteLine("11--------------------------------------------------");
Console.WriteLine("");





// ----- LINQ Method Syntax vs Query ----- 

// LINQ Query Syntax:

IEnumerable<int> scoreQuery3 =
    from score in scores
    where score > 80
    orderby score descending
    select score;



// LINQ Methods Syntax:

var scoreQuery4 = scores.Where(s => s > 80).OrderByDescending(s => s);


// Samling

List<int> myScores1 = scoreQuery3.ToList();
List<int> myScores2 = scoreQuery4.ToList();


Console.WriteLine("LINQ Query:");
foreach (var score in myScores1)
{
    Console.WriteLine(score);
}


Console.WriteLine("LINQ Method");
foreach (var score in myScores2)
{
    Console.WriteLine(score);
}



