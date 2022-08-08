Console.Clear();
Console.WriteLine("Enter the first number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
if (number > number2)
{
    max = number;
}
else
{
    max = number2;
}
Console.WriteLine(max);