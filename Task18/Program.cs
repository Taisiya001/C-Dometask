Console.WriteLine("Введите число");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int NumberB = Convert.ToInt32(Console.ReadLine());
int Method(int N, int B)
{
    int s = 0;
    int r = 1;
    for(int i = 1; i <= B ; i++)
    {
        s = r*N;
        r = s; 
        Console.WriteLine(s);
    }
    return s;
}
Method(NumberA,NumberB);
