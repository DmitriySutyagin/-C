Console.Clear();
int []arr(int size,int min, int max)
{
    Random rand = new Random();
    int [] array = new int[size];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
int [] point = arr(10,0,10);
int sum = 0;
for(int i = 1;i < point.Length;i+=2)
{
    sum = sum + point [i];
}
Console.WriteLine('[' + string.Join(", ", point) + ']');
Console.WriteLine($"Суььф не четных значений массива равна :{sum}");