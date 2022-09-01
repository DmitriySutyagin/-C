// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();

int[] Fibo(int N)
{
    int[] F = new int[N];
    for(int i = 2;i < F.Length;i++)
    {
        F[0] = 0;
        F[1] = 1;
        F[i] = F[i - 1] + F[i - 2];
    }
    return F;
}
Console.WriteLine("Enter number N:");
int N = Convert.ToInt32(Console.ReadLine());
int[] Fibonachi = Fibo(N);
Console.WriteLine(string.Join(" ", Fibonachi));

