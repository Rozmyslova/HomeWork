//Заполните спирально массив.

Console.Write("Enter array dimension (rows, columns by a space): ");
string [] inputArray = Console.ReadLine().Split();
int row = int.Parse(inputArray[0]);
int column = int.Parse(inputArray[1]);
CorrectArray(row, column);
int [,] array = new int [row, column];
int num = 1;
int i = 0;
int j = 0;
int firstRow = 0;
int lastRow = 0;
int firstColumn = 0;
int lastColumn = 0;
while (num <= (row*column)) // закончить, когда заполниться последним эл-том (д/массива 4х4 этот эл-т равен 16)
{
    array[i, j] = num;
    if ((i == firstRow) && (j < (column - 1 - lastColumn))) //двигаемся вправо до крайнего правого столбца
    {
        j++;
    }
    else if ((j == (column - 1 - lastColumn)) && (i < (row - 1 - lastRow))) //двигаемся вниз до крайней нижней строки
    {
        i++;
    }
    else if ((i == (row - 1 - lastRow)) && (j > firstColumn)) //двигаемся влево до крайнего левого столбца
    {
        j--;
    }
    else //двигаемся вверх до крайней верхней строки строки
    {
        i--;
    }
    
// проверяем, когда необходимо обходить по меньшему периметру
    if ((i == firstRow + 1) && (j == firstColumn) && (firstColumn != (column - 1 - lastColumn)))
    {
        firstRow++;
        lastRow++;
        firstColumn++;
        lastColumn++;
    }
    num++;

}
PrintArray(array);

void CorrectArray(int row, int column)
{
    if ((row < 0) || (column < 0))
    {
    Console.WriteLine("Array is incorrectly apecified");
    return;
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