Console.WriteLine("Введите число");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number8 = Convert.ToInt32(Console.ReadLine());
int [] arr = {Number1, Number2, Number3, Number4, Number5, Number6, Number7, Number8};

void PrintArray(int[] array)
{
   int count = array.Length;
   for(int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]} ");
    }
   Console.WriteLine();
}
PrintArray(arr);