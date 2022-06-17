Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

void Method(int N)
{
    for(int i = 0; i <= N ; i++)
    {
        int s = i*i*i;
        Console.WriteLine($"{s}");
    }
}
Method(Number);

