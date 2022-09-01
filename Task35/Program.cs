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
int count = 0;
int[] array = FillArray(123,0, 100);
for(int i = 0;i < array.Length;i++)
{
    if(array[i] > 9 && array[i] < 100)  count++;
}
Console.WriteLine();
Console.WriteLine(count);
Console.WriteLine('[' + string.Join(", ", array) + ']');
