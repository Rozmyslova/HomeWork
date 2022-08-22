/*Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.*/

Console.Write("Enter the first boundary number = ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the second boundary number = ");
int secondNumber = int.Parse(Console.ReadLine());
int temp = 0;
if (firstNumber > secondNumber)
{
    temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}
PrintNumber(firstNumber, secondNumber);

void PrintNumber(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return;
    }
    Console.Write(firstNumber + " ");
    PrintNumber(firstNumber + 1, secondNumber);
}
