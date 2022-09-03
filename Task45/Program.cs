Console.Clear();
int[] point(int size)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1,10);
    }  
    return arr;
}
void PrintArray(int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i];
    }
    return ;
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = point(size);
Console.WriteLine('[' + string.Join(", ", array) + ']');
PrintArray(array);
Console.WriteLine('[' + string.Join(", ", array) + ']');
