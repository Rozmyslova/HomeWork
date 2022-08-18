//Заполните спирально массив 4 на 4.

int row = 4;
int column = row;
int [,] array = new int [row, column];
int num = 1;
int i = 0;
int j = 0;
while (j < column)
{
    array[i, j] = num;
    num++;
    j++;
}
j -= 1;
i += 1;
while (i < row)
{
    array[i, j] = num;
    num++;
    i++;
}
i -= 1;
j -= 1;
while (j >= 0)
{
    array[i, j] = num;
    num++;
    j--;
}
j += 1;
i -= 1;
while ((i) > 0)
{
    array[i, j] = num;
    num++;
    i--;
}
i += 1;
j += 1;
while (j < (column -1))
{
    array[i, j] = num;
    num++;
    j++;
}
i += 1;
j -= 1;
while (j > 0)
{
    array[i, j] = num;
    num++;
    j--;
}
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
