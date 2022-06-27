Console.WriteLine("Введите число");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int k2 = Convert.ToInt32(Console.ReadLine());
int x = 0;
int y1 = 0;
int y2 = 0;
int FindX ()
{
    x = b2-b1 / k1-k2;
    return x;
}

void FindY ()
{
    y1 = k1*x + b1;
    y2 = k2*x + b2;
    if (y1 == y2) 
    {
        Console.WriteLine($"{x} {y1}");
    }
}
FindY();
FindX();