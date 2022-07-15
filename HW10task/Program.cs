/* Напишите программу, которая принимает на вход трехзначное число
и на выходе показывает вторую цифру*/

Console.Write("Enter three-digit number = ");
int number = int.Parse(Console.ReadLine());
int TwoDigit = Math.Abs(number) / 10;
int SecondDigit = TwoDigit % 10;
Console.WriteLine("Second digit in three-digit number " + number + " is " + SecondDigit);