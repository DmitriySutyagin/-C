
Console.Clear();
double [] x = new double [3];                             //A (7,-5, 0); B (1,-1,9) -> 11.53
double [] y = new double [3];
Console.WriteLine("Enter x1 coordinate :");                //A (3,6,8); B (2,1,-7), -> 15.84
x [0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y1 coordinate :");
x [1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter z1 coordinate :");
x [2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x2 coordinate :");
y [0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y2 coordinate :");
y [1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter z2 coordinate :");
y [2] = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(y[0] - x[0],2) + Math.Pow(y[1] - x[1],2) + Math.Pow(y[2] - x[2],2));
Console.WriteLine(length);