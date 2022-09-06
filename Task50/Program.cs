// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.WriteLine("Enter the number of rows of the two-dimensional array");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the two-dimensional array");
int m = Convert.ToInt32(Console.ReadLine());
int[,] point = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        point[i, j] = new Random().Next(0, 10);
        Console.Write(point[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Enter row index");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column index");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if ((k-1) >= n || (k-1) <= -1) Console.WriteLine("There is no such number in the array");
else if ((l-1) >= m || (l-1) <= -1) Console.WriteLine("There is no such number in the array");
else Console.WriteLine($"Your number: {point[k-1, l-1]}");