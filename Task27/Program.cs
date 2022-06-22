int[] fillArray()
{
    int[] array = new int[12];
    for(int i=0;i < array.Length;i++)
    {
        array[i] =new Random().Next(0,1000);
    }
    return array;
}
int[] arr = fillArray();

void ArraySum(int[] array)
{
    for(int i = 0; i < array.Length;i++ )
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArraySum(arr);

void MaxMin(int[] arr)
{
    int Max = arr[0];
    int SumMin = 0;
    for(int i = 0; i < arr.Length;i++)
    {
        if(arr[i] > Max)
        {
            Max = arr[i];
        }
}
    int Min = arr[0];
    for(int j = 0; j < arr.Length;j++)
    {
        if(arr[j] < Min)
        {
            Min = arr[j];
        }
}
    SumMin = Max - Min;
    System.Console.WriteLine($"{Max} ");
    System.Console.WriteLine($"{Min} ");
    System.Console.WriteLine($"{SumMin} ");
}
MaxMin(arr);