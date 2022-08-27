Console.Clear();
int N = 8;
int max = 10000;
int min = -10000;
int [] arr(int N,int min,int max)
{
    int [] point = new int [N];
    for (int i = 0;i < N;i++)
    {
        point[i] =  new Random().Next(min,max + 1);
    }
    return point;
}
void PrintArray(int [] arr)
{
    for(int i = 0;i < arr.Length;i++)
    {
        Console.Write($"{arr[i]}");
    }
}
// PrintArray(arr(N, min, max));
Console.WriteLine('['+string.Join(",",arr(N,min,max))+']');