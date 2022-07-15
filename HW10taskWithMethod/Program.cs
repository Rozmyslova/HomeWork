/* Напишите программу, которая принимает на вход трехзначное число
и на выходе показывает вторую цифру c использованием метода*/

Console.Write("Enter three-digit number = ");
int number = int.Parse(Console.ReadLine());
int result = SecNum(number);
Console.WriteLine("Second digit in three-digit number " + number + " is " + result);
int SecNum(int num)
{
    int TwoDigit = Math.Abs(num) / 10;
    int SecondDigit = TwoDigit % 10;
    return SecondDigit;
}

