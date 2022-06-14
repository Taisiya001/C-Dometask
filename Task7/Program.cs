int Number = new Random().Next(100,1000);
Console.WriteLine(Number);
int NumberA = Number / 100;
int NumberB = Number / 10;
int NumberC = NumberB%10;
int NumberD = NumberC%10;


Console.WriteLine(NumberD);


