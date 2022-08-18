/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива. */

Console.Write("Enter array dimension (rows, columns by a space): ");
string [] inputArray = Console.ReadLine().Split();
int row = int.Parse(inputArray[0]);
int column = int.Parse(inputArray[1]);
CorrectArray(row, column);
int [,] array = new int [row, column];
FillArray(array);
PrintArray(array);

int temp = array[row-1, column-1];
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
            }
            }
        }
    }
Console.WriteLine();
PrintArray(array);

void CorrectArray(int row, int column)
{
    if ((row < 0) || (column < 0))
    {
    Console.WriteLine("Array is incorrectly apecified");
    return;
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
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
