Console.Clear();
int [] point (int size,int min, int max)
{
    Random rand =new Random();

    int [] arr = new int [size]; 
    for(int i = 0;i < arr.Length;i++)
    {
        arr[i] = rand.Next(min,max);
    }
    return arr;

}
int [] array = point(10,99,1000);
int count = 0;
for(int i = 0;i < array.Length;i++)
{
    if(array[i] % 2 == 0) 
    {
        count++;

    }
}
Console.WriteLine($"В даннои массиве {count} четных чисел");
Console.WriteLine('[' + string.Join(",",array) + ']');