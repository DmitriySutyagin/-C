Console.Clear();
Console.WriteLine("Enter number N :");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
for(int i = 0;i <= N;i++)
{
    Console.WriteLine(i*i*i);
}
