
int A = new Random().Next(1,101);

Console.WriteLine("Определение чётности числа!");
Console.Write("Дано число ");
Console.WriteLine(A);

if(A % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}
