// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
double[] MiddleColms(int[,] point)
{
    double[] Avereng = new double[point.GetLength(1)];

    for (int l = 0; l < point.GetLength(1); l++)
    {
        double Avareng = 0;
        double sum = 0;
        for (int k = 0; k < point.GetLength(0); k++)
        {
            sum = sum + point[k, l];
            Avareng = sum / point.GetLength(0);
            Avareng = Math.Round(Avareng, 1);
        }
        
        Console.Write($"Column average: {Avareng + " "}");
    }
    return Avereng;
}
Console.WriteLine();
MiddleColms(point);



