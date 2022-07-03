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
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        double result1 = array.GetLength(0);
        for (int i = 0; i < array.GetLength(0); i++)
            {
                result += array[i,j];
                Console.WriteLine($"{result}");
            }
        Console.WriteLine($"Среднее арифметическое  {result/result1}");
    } 
}
int[,] arr = CreateArray(3,4);
FillArray(arr);
PrintArray(arr);
SumArray(arr);
