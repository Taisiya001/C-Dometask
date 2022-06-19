Console.WriteLine("Введите число");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int NumberB = Convert.ToInt32(Console.ReadLine());
int Method(int N, int B)
{
    int r = 1;
    for(int i = 1; i <= B ; i++)
    {
        r = r*N;
    }
    return r;
}
Console.WriteLine(Method(NumberA,NumberB));
