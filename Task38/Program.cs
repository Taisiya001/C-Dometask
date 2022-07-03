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
void FindArray(int [,] array)
{
    Console.WriteLine("Введите число");
    double b1 = Convert.ToDouble(Console.ReadLine());
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(b1 == array[i,j])  
           {
               result = b1;
           }
           if(b1 != array[i,j])
           {
               result = 0;
           }    
        } 
   }
   if(result == b1) 
   {
    Console.WriteLine($"{b1}");
   }
   if(result == 0)
   {
    Console.WriteLine("Такого числа нет");
   }
}
int[,] arr = CreateArray(3, 4);
FillArray(arr);
PrintArray(arr);
FindArray(arr);