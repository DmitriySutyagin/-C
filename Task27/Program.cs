// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Clear();

int arr (string N)
{
    int n = N.Length;
    int sum = 0;
    for(int i = 0;i < n;i++)
    {
       sum = sum + Convert.ToInt32(N[i].ToString());
    }
    
    return sum;
}
string? number = Console.ReadLine();
int sum = arr(number);
Console.WriteLine(sum);