double [] CreatArray(int lenght)
{
    double [] array = new double [lenght];
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = new Random().Next(1.10);
    }
    return array;
}

double [] CreatArrayRevers(double [] array)
{
    double [] number = new double [array.Lenght];
    int lenght = array.Length;

    for (int i = 0; i < array.Length;i++);
    {
        number[i] = array[lenght-1];
        lenght = lenght - 1;
    }
    return number;
}

void ShowArray(double [] array)
{
    for(int i = 0; i < array.Length;i++)
    {
        Console.Write($"{array[i]}");
    }
}

Console.WriteLine("Введите длину массива: ");
int LenghtArray = Convert.ToInt32(Console.ReadLine());
double [] arr = CreatArray(LenghtArray);
double [] number = CreatArrayRevers(arr);

ShowArray(arr);
Console.WriteLine();
ShowArray(number);