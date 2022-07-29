int Summ = 0;
Console.Write("\nВведите количество чисел в массиве: ");
int Quantity = 0;
Quantity = int.Parse(Console.ReadLine());
int[] Numbers = new int[Quantity];
Console.Write("\nДан массив: [");
for(int i = 0; i < Numbers.Length; i++)
{
    Numbers[i] = new Random().Next(-99,100);
    if(i % 2 != 0) //Извините непрпвильно понял, для исправления необходимо было только поменять одну переменную в условие
    {
        Summ += Numbers[i];
    }
    if(i == Numbers.Length - 1)
    {
        Console.WriteLine($"{Numbers[i]}]");
        break;
    }

    Console.Write($"{Numbers[i]}, ");
}

Console.WriteLine($"\nСумма нечетных чисел массива равна {Summ}\n");
