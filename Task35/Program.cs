int[] fillArray()
{
    int[] array = new int[12];
    for(int i=0;i < array.Length;i++)
    {
        array[i] =new Random().Next(-1000,1000);
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
{;
    int count = 0;
    for(int i = 0; i < arr.Length;i++)
    {
        if(arr[i] > 0)
        {
            count = count + 1;
        }
    }
    System.Console.Write($"{count}");
}
MaxMin(arr);