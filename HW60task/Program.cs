/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента. */


Console.Write("Enter array dimension (rows, columns, layer by a space): ");
string [] inputArray = Console.ReadLine().Split();
int row = int.Parse(inputArray[0]);
int column = int.Parse(inputArray[1]);
int layer = int.Parse(inputArray[2]);
CorrectArray(row, column, layer);
int [,,] array = new int [row, column, layer];
FillArray(array);
PrintArray(array);

void CorrectArray(int row, int column, int layer)
{
    if ((row < 0) || (column < 0) || (layer < 0))
    {
    Console.WriteLine("Array is incorrectly apecified");
    return;
    }
}

void FillArray(int[,,] array)
{
    int temp = 0;
    //int temp2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = 10 + temp;
                temp++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write(array[i,j,k] + " (" + i + ", " + j + ", " + k + ")\n");
        }
        Console.WriteLine();
        }
    }
}
