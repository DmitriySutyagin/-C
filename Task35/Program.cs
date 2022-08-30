Console.Clear();
int[] FillArray(int size, int min, int max)
{
    Random rand = new Random();
    int [] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

int[] array = FillArray(123,0, 100);
int a = 10;
int b = 99;
for(int i = a;i <= b;i++)
{
    Console.Write('[' + string.Join(", ", array[i]) + ']');
}
Console.WriteLine();
Console.WriteLine('[' + string.Join(", ", array) + ']');
