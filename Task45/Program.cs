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
void Sort(int [,] array)
{  
   for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int tmp = array[i, j-1];
            if (array[i, j] < array[i, j-1])
            {
                array[i, j-1] = array[i, j];
                array[i, j] = tmp;
            }
        }
    }
}
int[,] arr = CreateArray(3, 3);
FillArray(arr);
PrintArray(arr);
Sort(arr);
PrintArray(arr);

