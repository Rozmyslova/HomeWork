/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным*/

Console.Write("Week Number is ");
int WeekNumber = int.Parse(Console.ReadLine());
if (WeekNumber == 6 || WeekNumber == 7)
{
    Console.WriteLine("This is weekend");
}
else
{
    if ((WeekNumber > 0) && (WeekNumber <= 5))
    {
        Console.Write("This is workday");
    }
    else
    {
        Console.Write("This isn't week number");
    }
}