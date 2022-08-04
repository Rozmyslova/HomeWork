/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.*/

Console.Write("Enter number A: A = ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter number B: B = ");
int B = int.Parse(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(A, B));
Console.WriteLine("A raised to B power = " + result);