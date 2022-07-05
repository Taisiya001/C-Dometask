int [,] CreateArray (int n, int m)
{
    return new int [n,m];
}

void  FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
void SumArray(int [,] array)
{   int sum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = array[j, i];
        }
        if(result > sum)
        {
            sum = result;
            index = i;
        }
    } 
    Console.WriteLine("Строка: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(array[i, index]);
    }
}
int[,] arr = CreateArray(3, 3);
FillArray(arr);
PrintArray(arr);
SumArray(arr);
