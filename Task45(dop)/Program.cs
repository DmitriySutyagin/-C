// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
// (использовать рекурсию)
// 4 -> 24
// 5 -> 120
Console.Clear();
void PrintMulti(int N)
{
    
    int count = -N;
    if(0 <= -N) count--;
    else return;
    
    PrintMulti(N * count);
    Console.WriteLine(N * count);
}

Console.WriteLine("Enter numbers N:");
int number = Convert.ToInt32(Console.ReadLine());
PrintMulti(number);