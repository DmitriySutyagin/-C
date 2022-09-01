Console.Clear();
double[] FillArray(int size)
{
    double [] arr = new double [size];
    for(int i = 0; i < arr.Length; i++)
    {
       Console.WriteLine("Введите  число :");
       double A = Convert.ToDouble(Console.ReadLine());
       arr[i] = A;
    }
    return arr;
}
Console.WriteLine("Сколько чисел вы будете вводить?");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
double[] point = FillArray(size);
for(int i = 0;i < point.Length;i++)
{
    if(point[i] > 0)   count++;
}    
Console.WriteLine($"Число чисел больше 0 равно:{count}");
