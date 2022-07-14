Console.Write("Enter number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2 = ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > max) {
    Console.WriteLine("Max = " + number2);
}
else {
    Console.WriteLine("Max = " + number1);
}