Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if(Number > 99)
{
    Console.WriteLine((Number / 10)%10);
}
if(Number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}