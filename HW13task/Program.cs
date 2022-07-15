Console.Write("Enter number = ");
double number = double.Parse(Console.ReadLine());
double Kolvo = 1;
Console.WriteLine(Kolvo);
double DopPeremen = number;
Console.WriteLine(DopPeremen);
while (DopPeremen > 0)
{
    DopPeremen = DopPeremen / 10;
    Kolvo = 1 + Kolvo;
}
Console.WriteLine(Kolvo);
if (Kolvo <= 2)
{
    Console.WriteLine("No third digit");
}
else
{
    double AddAction = number / (Math.Pow(10, Kolvo - 3));
    Console.WriteLine(AddAction);
    double ThirdDigit = AddAction % 10;
    Console.WriteLine("Third digit is " + ThirdDigit);
}