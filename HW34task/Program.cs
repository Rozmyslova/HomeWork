/* Задайте массив заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве.*/

Console.Write("Enter length of array = ");
int length = int.Parse(Console.ReadLine());
int [] array = new int [length];
FillArray(array);
PrintArray(array);
int kolvo = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0)
    {
        kolvo += 1;
    } 
}
Console.WriteLine("\nThe numbers of even elements of an array: kolvo = " + kolvo);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
