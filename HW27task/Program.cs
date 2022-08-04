// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter number = ");
int number = int.Parse(Console.ReadLine());
if ((number < 10) && (number >= 0))
{
    Console.WriteLine("Sum of digits = " + number);
}
else 
{
    int sum = 0;
    int num = Math.Abs(number);
        while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine("Sum of digits = " + sum);
}