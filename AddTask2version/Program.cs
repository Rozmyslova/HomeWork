/* Не используя встроенных функций, найти с точностью до десятых квадратный корень 
введенного пользователем числа. Число должно целым в диапазоне от 1 до 100.
C учетом метода Ньютона */

Console.Write("Enter a number in rande [1; 100]: Number = ");
double number = double.Parse(Console.ReadLine());
double sqrt = 1;
while (true)
{
    double number2 = (sqrt + number / sqrt) / 2;
    if (Math.Abs(sqrt - number2) < 0.01) 
    {
        break;
    }
    sqrt = number2;
}
Console.WriteLine(Math.Round(sqrt, 1));