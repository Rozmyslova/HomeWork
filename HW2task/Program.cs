// Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

Console.Write("Enter number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2 = ");
int number2 = int.Parse(Console.ReadLine());
if (number2 > number1) {
    Console.WriteLine("Max = " + number2);
}
else {
    Console.WriteLine("Max = " + number1);
}