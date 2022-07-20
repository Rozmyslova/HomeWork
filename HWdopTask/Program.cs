/*Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме. 
На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат.*/

Console.WriteLine("Введите цифру, которая соответствует фигуре, площадь которой надо найти: 1 - круг, 2 - прямоугольник, 3 - треугольник");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.Write("Введите радиус круга r = ");
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine("Площадь круга равна " + AreaofCircle(r));
}
else
{
    if (number == 2)
    {
        Console.Write("Введите длину прямоугольника a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите ширину прямоугольника b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Площадь прямоугольника равна " + AreaofRectangular(a, b));
    }
    else 
    {
        if (number == 3)
        {
            Console.Write("Введите основание треугольника osn = ");
            double osn = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту треугольника h = ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь треугольника равна " + AreaofTriangle(osn, h));
        }
        else
        {
            Console.WriteLine("Нет такой фигуры");
        }
    }
}


double AreaofCircle(double r)
{
    double SofCircle = Math.Round((Math.PI * Math.Pow(r, 2)), 2);
    return SofCircle;
}

double AreaofRectangular(double a, double b)
{
    double SofRectangular = a * b;
    return SofRectangular;
}

double AreaofTriangle(double a, double h)
{
    double SofTriangle =  Math.Round(a * h / 2, 2);
    return SofTriangle;
}