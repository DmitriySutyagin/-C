Console.Clear();
Console.WriteLine("Enter a three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number > 99 && number < 1000)
{
    result = number % 100 / 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Enter a positive three-digit number");
}