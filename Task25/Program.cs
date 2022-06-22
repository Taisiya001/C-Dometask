int[] fillArray()
{
    int[] array = new int[12];
    for(int i=0;i < array.Length;i++)
    {
        array[i] =new Random().Next(0,10);
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

void SumPlusAndMinus(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length;i++)
    {
        int element = arr[i];
        if(element % 2 == 0)
        {
            count = count + 1;
        }  
    }
    System.Console.WriteLine($"{count} ");
}
SumPlusAndMinus(arr);
