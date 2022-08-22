/*Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.*/

Console.Write("Enter the first number = ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the second number = ");
int secondNumber = int.Parse(Console.ReadLine());
if ((firstNumber >= 0) && (secondNumber >= 0))
{
    Console.WriteLine("Ackerman function = " + AckermanFunction(firstNumber, secondNumber));
}
else
{
    Console.WriteLine("Function can`t be calculate");
}

int AckermanFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (secondNumber == 0)
    {
        return AckermanFunction(firstNumber - 1, 1);
    }
    else 
    {
        return AckermanFunction(firstNumber - 1, AckermanFunction(firstNumber, secondNumber - 1));
    }
}

