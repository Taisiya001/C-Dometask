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
int [,] CreateArray1 (int a, int b)
{
    return new int [a,b];
}

void  FillArray1(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray1(int [,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
void SumArray(int [,] array, int [,] arr)
{   
    int[,] m = new int[array.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                m[i,k] += array[i,j]*array[j,k];
            }
            Console.WriteLine($"{m[i,j]} + ");
        }
        
    }
    
}
int[,] array = CreateArray(3, 3);
int[,] arr = CreateArray1(3,3);
FillArray(array);
FillArray1(arr);
PrintArray(array);
PrintArray1(arr);
SumArray(array,arr);
