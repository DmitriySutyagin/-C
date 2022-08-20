Console.Clear();
string?[] point = new string [5];
Console.WriteLine("Enter five-digit number");
point[0] = Convert.ToString(Console.Read());
point[1] = Convert.ToString(Console.Read());
point[2] = Convert.ToString(Console.Read());
point[3] = Convert.ToString(Console.Read());
point[4] = Convert.ToString(Console.Read());
if(point[0] == point[4] && point[1] == point[3])
{
    Console.WriteLine("Number of polydrome");
}
else
{
    Console.WriteLine("The number is not a polydrome");
}