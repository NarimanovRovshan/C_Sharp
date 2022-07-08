// See https://aka.ms/new-console-template for more information

int A = new Random().Next(1,101);
int B = new Random().Next(1,101);

Console.WriteLine("Сравнение двух чисел!");
Console.Write("Первое число: ");
Console.WriteLine(A);
Console.Write("Второе число: ");
Console.WriteLine(B);

if (A > B)
{
    Console.Write("Число ");
    Console.Write(A);
    Console.Write(" больше числа ");
    Console.Write(B);
}
else
{
    Console.Write("Число ");
    Console.Write(B);
    Console.Write(" больше числа ");
    Console.Write(A);
}
