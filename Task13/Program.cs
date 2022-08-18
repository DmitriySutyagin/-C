Console.Clear();
Console.WriteLine("Enter number");
string? number = Console.ReadLine();
Console.WriteLine($"Your number : {number}");
int thrid = int.Parse(number [2].ToString());
Console.WriteLine($"{thrid}");
int n = number.Length;
int i = 3;
if (n < i )
{
    Console.WriteLine("No third digit");
}