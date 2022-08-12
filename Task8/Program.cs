Console.Clear();
Console.WriteLine("Enter number N");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
{
   if (i % 2 == 0)
   {
      Console.WriteLine(i);
      i+=2;
   }
   else
   {
      i++;
   }  
}
