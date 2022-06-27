int[] fillArray(int N1)
{
    int[] array = new int[N1]; 
    return array;
}

void ArrayShow(int[] arr)
{
    for(int i = 0; i < arr.Length;i++ )
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Fibonach(int[] arr)
{
    if (arr.Length == 1)
    {
        arr[0] = 0;
        return;
    }
    if (arr.Length == 2)
    {
        arr[0] = 0;
        arr[1] = 1;
        return;
    }
    arr[0] = 0;
    arr[1] = 1;
    for(int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];   
    }
    return;
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = fillArray(N);

ArrayShow(arr);
Fibonach(arr);
ArrayShow(arr);