/* Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.*/

Console.Write("Enter length of array = ");
int length = int.Parse(Console.ReadLine());
double [] array = new double [length];
FillArray(array);
PrintArray(array);
double result = MaxNum(array) - MinNum(array);
Console.WriteLine("\nresult = " + result);


void FillArray(double[] array)
{
    Random random = new Random();
    double min = -100.0;
    double max = 100.0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = min + (random.NextDouble() * (max - min));
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
double MaxNum(double [] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double MinNum(double [] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

