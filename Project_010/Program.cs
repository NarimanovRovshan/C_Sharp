int Number;
Console.Write("\nВведите максимальное число до которого будет ввестись расчет: ");
Number = int.Parse(Console.ReadLine());

for(int i = 1; i <= Number; i++)
{   
    if(i == Number)
    {
        Console.WriteLine($"{Math.Pow(i,3)}.\n");
        break;
    }
    Console.Write($"{Math.Pow(i,3)}, ");
}