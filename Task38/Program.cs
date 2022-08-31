Console.Clear();
double[] FillArray(int size)
{
    double [] arr = new double [size];
    for(int i = 0; i < arr.Length; i++)
    {
       Console.WriteLine("Введите  число массива :");
       double A = Convert.ToDouble(Console.ReadLine());
       arr[i] = A;
    }
    return arr;
}
Console.WriteLine("Введите размер число массива :");
int size = Convert.ToInt32(Console.ReadLine());
double result = 0;
double[] array = FillArray(size);
double min = array[0];
double max = array[0];
for(int i = 0;i < array.Length;i++)
{
    if(max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
result = max - min;
Console.WriteLine($"Разница min and max {result}");
Console.WriteLine('[' + string.Join(", ", array) + ']');
