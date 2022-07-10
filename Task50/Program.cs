int Akkerman(int N, int M)
{
    if(N == 0)
    {
        return M + 1;
    }
    if(M == 0 && N > 0)
    {
        return Akkerman(N-1,1);
    }
    return Akkerman(N-1,Akkerman(N,M-1));
}
int result = Akkerman(1,3);

Console.WriteLine(result);