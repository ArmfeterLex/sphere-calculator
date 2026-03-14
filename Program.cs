using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус шара");
        double a = double.Parse(Console.ReadLine());
        double s = Math.Round(4 * Math.PI * (a * a), 2); double v = Math.Round((4 * Math.PI * (a * a * a)) / 3, 2);
        Console.WriteLine("Площадь шара {0:f2}; Обьем шара {1:f2}", s, v);
        Console.ReadKey();
    }
}
