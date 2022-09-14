// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int[] SumStrPoint(int[,] point)
{
    int[] SumString = new int[point.GetLength(1)];
    for (int i = 0; i < point.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < point.GetLength(1); j++)
        {
            sum = sum + point[i, j];
        }
        Console.Write(sum + " ");
        
    }

    return SumString;
}
SumStrPoint(point);
Console.WriteLine();
// void SumStringSort(int []SumString)
// {
//     for (int i = 0; i < SumString.Length; i++)
//     {
//         for (int j = i + 1; j < SumString.Length; j++)
//         {

//             if (SumString[i] < SumString[j])
//             {
//                 int temp = SumString[j];
//                 SumString[j] = j;
//                 j = temp;
//                 Console.WriteLine(j);

//             }
//         }
//     }
// }
// SumStringSort(SumString);

