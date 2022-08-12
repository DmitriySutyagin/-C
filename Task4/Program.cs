Console.Clear();
Console.WriteLine("Enter the first number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number;
if (number2 > max)
{
    max = number2;
}
else
{
    while (number3 > max)
    {
        max = number3;
    }

}
Console.WriteLine(max);