/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.*/

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
Console.Write("Sum = " + Sum(firstNumber, secondNumber));

int Sum(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber)
    {
        return Sum(firstNumber + 1, secondNumber) + firstNumber;
    }
    return secondNumber;
}
