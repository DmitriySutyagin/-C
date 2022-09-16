// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.WriteLine("Enter the number of rows of the two-dimensional array");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the two-dimensional array");
int m = Convert.ToInt32(Console.ReadLine());
int[,] FirstMatrix = new int[n, m];
for (int i = 0; i < FirstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
    {
        FirstMatrix[i, j] = new Random().Next(0, 10);
        Console.Write(FirstMatrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] SecondMatrix = new int[m, n];
{
    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            SecondMatrix[i, j] = new Random().Next(0, 10);
            Console.Write(SecondMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

