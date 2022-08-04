// SНапишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Enter length of array = ");
int length = int.Parse(Console.ReadLine());
int [] array = new int [length];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

