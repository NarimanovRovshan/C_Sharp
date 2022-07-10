int A = new Random().Next(0,100000);
Console.WriteLine("");
Console.WriteLine("Показать третью цифру произвольного числа.");
Console.WriteLine("");

Console.Write("Дано число ");
Console.WriteLine(A);
Console.WriteLine("");

while(true)
{
    if(A < 100)
    {
        Console.WriteLine("--> Третьей цифры НЕТ!!! <--");
        Console.WriteLine("");
        break;
    }
    if(A < 1000){
        A = A % 10;
        Console.Write("Третья цифра этого числа ");
        Console.WriteLine(A);
        Console.WriteLine("");
        break;
    }
    A = A / 10;
}