// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Использование Math.Pow и аналогов = незачёт
Console.Clear();

int array(int B, int A)
{
    int mul = 1;
    for (int i = 0; i < B;i++)    {
        mul = mul * A;    
    }
    return mul;
}

Console.WriteLine("Enter number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B:");
int B = Convert.ToInt32(Console.ReadLine());
int C = array(B,A);
Console.WriteLine(C);