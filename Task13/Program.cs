Console.Clear();
Console.WriteLine("Enter number");
string? a = Console.ReadLine();
Console.WriteLine($"Your number : {a}");
int thrid = int.Parse ( a [2].ToString());
Console.WriteLine($"{thrid}");
int n = int.Parse(a.Length.ToString());

if (n == 2)   Console.WriteLine("No thrid digit");

