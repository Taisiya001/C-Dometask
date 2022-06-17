Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

void Number1(int N)
{
    int N1 = N%10;
    int N2 = N/10000;
    int N3 = (N/10)%10;
    int N4 = (N/1000)%10;
    if(N1 == N2 && N3 == N4)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
Number1(Number);