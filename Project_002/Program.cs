
int A = new Random().Next(1,101);
int B = new Random().Next(1,101);
int C = new Random().Next(1,101);
int Max = A;
string Result = " первое число"; 
Console.WriteLine("Сравнение трёх чисел!");
Console.Write("Первое число: ");
Console.WriteLine(A);
Console.Write("Второе число: ");
Console.WriteLine(B);
Console.Write("Третье число: ");
Console.WriteLine(C);

if (Max < B)
{
    Max = B;
    Result = " второе число";
}

if (Max < C)
{
    Max = C;
    Result = " третье число";
}

Console.Write("Из трёх чисел");
Console.Write(Result);
Console.Write(" самое большое, равное ");
Console.WriteLine(Max);

