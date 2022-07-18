Console.Write("\nВведите количество чисел в массиве: ");
int Quantity = int.Parse(Console.ReadLine());
Console.Write("\nДан массив: [");
int[] Numbers = new int[Quantity];
for(int i = 0; i < Numbers.Length; i++)
{
    Numbers[i] = new Random().Next(0,101);
    if(i == Numbers.Length - 1)
    {
        Console.WriteLine($"{Numbers[i]}]");
        break;
    }
    Console.Write($"{Numbers[i]}, ");
}
int Max = Numbers[0];
int Min = Numbers[0]; 
for(int i = 1; i < Numbers.Length; i++)
{
    if(Numbers[i] > Max)
    {
        Max = Numbers[i];
    }
    if(Numbers[i] < Min)
    {
        Min = Numbers[i];
    }
}
Console.WriteLine($"\nРазница между максимальным числом массива, которое равно {Max}, и минимальным числом массива, которое равно {Min}, равно {Max - Min}\n");