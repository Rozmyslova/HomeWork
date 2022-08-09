/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях. */

Console.Write("Enter length of array = ");
int length = int.Parse(Console.ReadLine());
int [] array = new int [length];
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 1; i < length; i += 2)
{
    sum += array[i]; 
}
Console.WriteLine("\nThe sum of the elements in odd position = " + sum);


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
}