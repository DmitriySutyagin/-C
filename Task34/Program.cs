Console.Clear();

int min = 99;
int max = 1000;
int [] point (int min, int max)
{
    Random rand =new Random();
    int count = 0;
    int [] arr = new int [10]; 
    for(int i = 0;i < arr.Length;i++)
    {
        arr[i] = rand.Next(min,max);
        if(arr[i] % 2 == 0) 
        {
            count++;
            Console.WriteLine($"В даннои массиве {count} четных чисел");

        }  
    }
    return arr;

}
Console.WriteLine('[' + string.Join(",",point(min,max)) + ']');

// int [] PrintArray(int [] point)
// {
//     for(int i = 0;i < point.Length;i++)
//     {
//         if(point[i] % 2 == 0)
//         {
//             i++;
//         }
//         Console.WriteLine($"В даннои массиве {i} четных чисел");
//     }
// }
