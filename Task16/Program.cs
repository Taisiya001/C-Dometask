void Distance(int x, int y, int z, int x1, int y1, int z1)
{
    double d = Math.Pow(x1-x,2) + Math.Pow(y1-y,2) + Math.Pow(z1-z,2);
    double sqr = Math.Sqrt(d);
    Console.WriteLine(sqr);
}
Distance (3,2,6,1,8,-7);