double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2) 
{
    double xLine = x2 - x1;
    double yLine = y2 - y1;
    double zLine = z2 - z1;

    double result = Math.Sqrt(xLine*xLine + yLine*yLine + zLine*zLine);

    return result;
}

Console.Write("Input x1 coord: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1 coord: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1 coord: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2 coord: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2 coord: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2 coord: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);