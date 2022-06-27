int countnumber = 0;

while(true)
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    countnumber = 0;
    int continue_ = 0;

    if(number > 0)
    {
        countnumber++;
    }
        while(true)
        {
            Console.WriteLine("Продолжить ввод?Да-1, Нет -0");
            continue_ = Convert.ToInt32(Console.ReadLine());
            if(continue_ == 0 || continue_== 1);
            break;
        }
    if (continue_ == 0)
    {
        break;
    }
}
Console.WriteLine($"Количество чисел больше нуля {countnumber}");