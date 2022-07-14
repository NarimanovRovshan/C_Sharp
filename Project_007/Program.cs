int Dey = new Random().Next(1,9);
Console.WriteLine("");
Console.Write("Являться ли ");
Console.Write(Dey);
Console.WriteLine(" день недели выходным?");
Console.WriteLine(" ");

if(Dey == 6 || Dey == 7)
{
    Console.WriteLine("Да, данный день являться выходным");
}
else
{
    Console.WriteLine("Нет, данный день не являться выходным");
}
Console.WriteLine(" ");