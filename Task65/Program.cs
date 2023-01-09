// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Enter the number M");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number N");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = n; i < m + 1; i++)   sum = sum + i;  Console.WriteLine(sum);

