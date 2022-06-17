Console.WriteLine("Введите число");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int NumberB = Convert.ToInt32(Console.ReadLine());
void Method(int N, int B)
{
    double d = Math.Pow(N,B);
    Console.WriteLine($"{d}");
}
Method(NumberA,NumberB);