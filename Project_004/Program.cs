
int A = new Random().Next(1,101);
int Index = 0;

Console.WriteLine("");
Console.WriteLine("Вывод четных чисел из массива!");
Console.WriteLine("");
Console.Write("Дано: массив из ");
Console.Write(A);
Console.Write(" чисел, от 0 до ");
Console.WriteLine(A);

Console.WriteLine("");
Console.Write("Вывод чётных чисел массива: [");

while(Index <= A)
{
    if(Index % 2 == 0)
    {
        Console.Write(Index);
            if(Index != A && Index != A -1)
            {
                Console.Write("; ");
            }
    }
    Index++;
}

Console.WriteLine("]");
Console.WriteLine("");        