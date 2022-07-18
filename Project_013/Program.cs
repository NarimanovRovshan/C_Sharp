// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ввывод массива из 8 чисел!");
int[] Numbers = new int[8];
    Console.Write("[");
for(int i = 0; i < Numbers.Length; i++)
{   
    Numbers[i] = new Random().Next(0,100);
    if(i == Numbers.Length -1 )
    {
        Console.Write($"{Numbers[i]}]");
        break;
    }
    Console.Write($"{Numbers[i]}, ");
}
