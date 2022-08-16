/* Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь. */

Console.Write("Enter M numbers separated by a space: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("The numbers of even elements of an array: count = " + count);