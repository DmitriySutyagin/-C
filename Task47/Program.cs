// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.Clear();
int n = 3;
int m = 4;
Random rand = new Random();
double[,] TwoArr = new double [n,m];
for(int i = 0;i < n;i++)
{
    for(int j = 0;j < m;j++)
    {
        TwoArr[i,j] = rand.NextDouble()*10;
        double k = TwoArr[i,j];
        k = Math.Round(k,1);
        Console.Write(k + " ");
    }
    Console.WriteLine();
}