/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */

Console.Write("Enter number of rows = ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns = ");
int column = int.Parse(Console.ReadLine());
double [,] array = new double [row, column];
FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    Random random = new Random();
    double min = -10.0;
    double max = 10.0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((min + (random.NextDouble() * (max - min))), 1);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 0)
            {
                Console.Write(array[i,j] + "\t");
            }
            else 
            {
                Console.Write(" " + array[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}
