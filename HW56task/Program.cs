/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

Console.Write("Enter dimension of the rectangular array (rows, columns by a space): ");
string [] inputArray = Console.ReadLine().Split();
int row = int.Parse(inputArray[0]);
int column = int.Parse(inputArray[1]);
if ((row < 0) || (column < 0) || (row == column))
{
    Console.WriteLine("Array is incorrectly apecified");
    return;
}
int [,] array = new int [row, column];
FillArray(array);
PrintArray(array);
int minsum = 1000;
int minrow = 0;
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    if (sum < minsum) 
    {
        minsum = sum;
        minrow = i + 1;
    }
    sum = 0;
} 
Console.WriteLine ("Minimum sum (" + minsum + ") of elements in " + minrow + " row");


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
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
