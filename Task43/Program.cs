// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Enter the first coordinate of the first line :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second coordinate of the first line :");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the first coordinate of the second line :");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second coordinate of the second line :");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = k2 * x +b2 ;
if(k1 == k2)    Console.WriteLine("The lines are parallel");
Console.WriteLine($"Координаты точки пересечения двух прямы ({x};{y})");