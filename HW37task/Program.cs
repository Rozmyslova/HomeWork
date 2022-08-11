/* Найдите произведение пар чисел в одномерном массиве.
Результат запишите в новом массиве */

Console.Write("Enter length of array = ");
int length = int.Parse(Console.ReadLine());
int [] array = new int [length];
FillArray(array);
PrintArray(array);
int lengthResult = 1;
if (length % 2 == 0)
{
    lengthResult = (int) length / 2;
}
else
{
    lengthResult = (int) length / 2 + 1;
}
int [] arrResult = new int [lengthResult];
for (int j = 0; j < lengthResult; j++)
{
    if (j != (length - 1 - j))
    {
        arrResult[j] = array[j]*array[(length - j - 1)];
    }
    else
    {
        arrResult[j] = array[j];
    }
}
PrintArray(arrResult);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
