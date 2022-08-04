/* Не используя встроенных функций, найти с точностью до десятых квадратный корень 
введенного пользователем числа. Число должно целым в диапазоне от 1 до 100. */

Console.Write("Enter a number in rande [1; 100]: Number = ");
double number = double.Parse(Console.ReadLine());
double i = 1;
while ((i * i) < number)
{
    i = i + 0.05;
}
if (((int) (i * 100 % 10)) == 5)
{
    i = i - 0.05;
}
Console.WriteLine(Math.Round(i, 1));