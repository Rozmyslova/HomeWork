/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

Console.Write("Enter array dimension (rows, columns by a space): ");
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
Console.Write("Enter element position: ");
int number = int.Parse(Console.ReadLine());
if (number > (row * column))
{
    Console.WriteLine("There isn`t this element in the array");
}
int length = row * column;
int [] newArray = new int [length];
int k = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
    newArray[k] = array[i, j];
    k++;
    }
}
Console.WriteLine("The element which located on position " + number + " is " + newArray[number - 1]);

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

