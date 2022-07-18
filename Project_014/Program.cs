Console.Write("\nВведите количество трехзначных чисел: ");
int Quantity = 0;
Quantity = int.Parse(Console.ReadLine());
int[] Numbers = new int[Quantity];
int Index = 0;
Console.Write("\nДан массив: [");
for(int i = 0; i < Numbers.Length; i++)
{
    Numbers[i] = new Random().Next(100,1000);
    if(Numbers[i] % 2 == 0)
    {   
        Index++;
    }
    if(i == Numbers.Length - 1)
    {
        Console.WriteLine($"{Numbers[i]}]");    
        break;
    }
    Console.Write($"{Numbers[i]}, ");
}

Console.WriteLine($"\nКоличество четных чисел в массиве равно {Index}\n");