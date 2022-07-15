/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Write("Enter number = ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int kolvo = 1;
int DopPeremen = number;
while ((DopPeremen / 10) > 0) 
{
    DopPeremen = DopPeremen / 10;
    kolvo = kolvo +1;
}
if (kolvo <= 2)
{
    Console.WriteLine("No third digit");
}
else 
{
    int AddVariable = Convert.ToInt32(Math.Truncate(number / (Math.Pow(10, kolvo - 3))));
    int ThirdDigit = AddVariable % 10;
    Console.WriteLine(ThirdDigit);
}