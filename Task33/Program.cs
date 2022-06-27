void coordinates()
{
    Console.WriteLine("Введите число");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число");
    double k2 = Convert.ToDouble(Console.ReadLine());

    intersectiPoint(b1, k1, b2, k2);
}

void intersectiPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k2-k1);
    double y = (k2*x) + b2;
    System.Console.WriteLine($"{x} {y}");
}
coordinates();