int[] fillArray()
{
    int[] array = new int[10];
     for(int i=0;i < array.Length;i++)
    {
        array[i] =new Random().Next(0,100);
    }
    return array;
}
int[] arr = fillArray();

void ArrayShow(int[] array)
{
    for(int i = 0; i < array.Length;i++ )
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Fibonach(int[] array)
{
    for(int i= 2;i < array.Length;i++)
    {
        array[i] = array[i-1] + array[i-2];   
    }
}
ArrayShow(arr);
Fibonach(arr);