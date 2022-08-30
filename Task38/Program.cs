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
double sum = 0;
double[] array = FillArray(size);
for(int i = 0;i < array.Length;i++)
{
    sum = array[0] - array[array.Length - 1];
    sum = Math.Abs(sum);
}
Console.WriteLine($"Разница чисел {sum}");
Console.WriteLine('[' + string.Join(", ", array) + ']');
