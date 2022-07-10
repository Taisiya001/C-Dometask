int Sum(int M, int N)
{   
  if(N != 1)
  {
    M += Sum(M, N-1);
  }
  return M;
}
System.Console.WriteLine(Sum(2,4));
