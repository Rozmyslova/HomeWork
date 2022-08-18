/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

Console.Write("Enter array dimension (rows, columns): ");
string [] inputArray = Console.ReadLine().Split();
int row = int.Parse(inputArray[0]);
int column = int.Parse(inputArray[1]);
if ((row < 0) || (column < 0))
{
    Console.WriteLine("Array is incorrectly apecified");
    return;
}
int [,] array = new int [row, column];
FillArray(array);
PrintArray(array);
Console.Write("Enter element position (m, n): ");
string [] input = Console.ReadLine().Split();
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);
if ((m >= row) || (m < 0) || (n >= column) || (n < 0))
{
    Console.WriteLine("There isn`t this element in the array");
}
else 
{
    Console.WriteLine("This element is " + array[m,n]);
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,100);;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

