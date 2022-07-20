/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Enter 5-digit number = ");
int number = int.Parse(Console.ReadLine());
int digit1 = number / 10000;
int digit2 = number / 1000 % 10;
int digit4 = number % 100 / 10;
int digit5 = number % 10;
if ((digit1 == digit5) && (digit2 == digit4))
{
    Console.WriteLine(number + " is palindrom");
}
else
{
   Console.WriteLine(number + " isn`t palindrom"); 
}