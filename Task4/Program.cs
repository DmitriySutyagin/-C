Console.Clear();
Console.WriteLine("Enter the first number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number;
if (number > number2)
{
    max = number;
}
else
{
    max = number2;
    if (number2 > number3);
    else
    {
        max = number3;
    }

}
Console.WriteLine(max);