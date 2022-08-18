/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */

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
double [] result = new double [column];
double sum = 0;
for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];        
        }   
        result[j] = Math.Round((sum / row), 1);
        sum = 0;
    }
Console.WriteLine("The array of arithmetic mean of the columns of a two-dimensional array is: ");
for (int j = 0; j < column; j++)
{
    Console.Write(result[j] + "\t");
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);;
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
