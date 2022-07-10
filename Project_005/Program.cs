int A = new Random().Next(100,1000);
Console.WriteLine("");
Console.WriteLine("Показать вторую цифру трёхзначного числа.");
Console.WriteLine("");

Console.Write("Дано число ");
Console.WriteLine(A);
Console.WriteLine("");

A = A % 100;
A = A / 10;

Console.Write("Вторая цифра этого числа ");
Console.WriteLine(A);
Console.WriteLine("");
