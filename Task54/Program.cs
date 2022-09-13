// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.WriteLine("Enter the number of rows of the two-dimensional array");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the two-dimensional array");
int m = Convert.ToInt32(Console.ReadLine());
int[,] point = new int[n, m];
for (int i = 0; i < point.GetLength(0); i++)
{
    for (int j = 0; j < point.GetLength(1); j++)
    {
        point[i, j] = new Random().Next(0, 10);
        Console.Write(point[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
void SelectionSort(int[,] point)
{
    for (int i = 0; i < point.GetLength(0); i++)
    {
        for (int j = 0; j < point.GetLength(1); j++)
        {
            for (int l = j + 1; l < point.GetLength(1); l++)
            {
                if (point[i, j] < point[i, l])
                {
                    int temp = point[i, j];
                    point[i, j] = point[i, l];
                    point[i, l] = temp;
                }
            }
        }
    }
}
void PrintPoint(int[,] point)
{
    for (int i = 0; i < point.GetLength(0); i++)
    {
        for (int j = 0; j < point.GetLength(1); j++)
        {
            Console.Write(point[i,j] + " ");
        }
        Console.WriteLine();
    }
}
SelectionSort(point);
PrintPoint(point);