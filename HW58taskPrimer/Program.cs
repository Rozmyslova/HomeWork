/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц. 
!! произведение ЭЛЕМЕНТОВ, находящихся на одинаковых позициях*/

Console.Write("Enter dimension of the first array (rows, columns by a space): ");
string [] inputFirstArray = Console.ReadLine().Split();
int row1 = int.Parse(inputFirstArray[0]);
int column1 = int.Parse(inputFirstArray[1]);
CorrectArray(row1, column1);
int [,] firstArray = new int [row1, column1];
FillArray(firstArray);
PrintArray(firstArray);

Console.Write("Enter dimension of the second array (rows, columns by a space): ");
string [] inputSecondArray = Console.ReadLine().Split();
int row2 = int.Parse(inputSecondArray[0]);
int column2 = int.Parse(inputSecondArray[1]);
CorrectArray(row2, column2);
int [,] secondArray = new int [row2, column2];
FillArray(secondArray);
PrintArray(secondArray);

if ((row1 != row2) && (column1 != column2))
{
    Console.WriteLine("It`s impossible to multiply these elements of 2 matrices");
    return;
}
int [,] resultArray = new int [row1, column1];

for (int i = 0; i < row1; i++)
{
    for (int j = 0; j < column2; j++)
    {
        resultArray[i,j] = firstArray[i,j]*secondArray[i,j];         
    }
}
Console.WriteLine("Multiplication result:");
PrintArray(resultArray);


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


