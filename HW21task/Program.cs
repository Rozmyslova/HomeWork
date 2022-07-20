/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Enter coordinate X of point A: xA = ");
double xA = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate Y of point A: yA = ");
double yA = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate Z of point A: zA = ");
double zA = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate X of point B: xB = ");
double xB = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate Y of point B: yB = ");
double yB = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate Z of point B: zB = ");
double zB = double.Parse(Console.ReadLine());
double Length = Math.Round((Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2))), 2);
Console.WriteLine("Length = " + Length);