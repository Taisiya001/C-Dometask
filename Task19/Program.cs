Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

int Method(int N) 
{
    int result = 0;
    for(int i = 0; i <= N ; i++)
    {
        result = result + N%10;
        N = N/10;
    }
    return result;
}
Console.WriteLine(Method(Number));