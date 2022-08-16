/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. */

Console.Write("Enter k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Enter b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Enter k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Enter b2 = ");
double b2 = double.Parse(Console.ReadLine());
if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Lines match");
}
else if (k1 == k2)
{
    Console.WriteLine("Lines don`t intersect, they`re parallel");
}
else
{
    double x = Math.Round(((b2-b1)/(k1-k2)), 1);
    double y = k1*x + b1;
    Console.WriteLine("Intersection point of two lines: (" + x + "; " + y + ")");
}
