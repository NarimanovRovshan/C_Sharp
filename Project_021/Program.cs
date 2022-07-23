//Пользователь создаёт массив 
Console.Clear();
Console.WriteLine("Нахождение среднего арифметического числа в столбиках массива.");
Console.Write("\nДо начала программы Вам необходимо ввести размер массива\n\nКоличество строк в массиве: ");
int  Lines= int.Parse(Console.ReadLine());
Console.Write("Количетсов столбцов в массиве: ");
int Columns = int.Parse(Console.ReadLine());
Console.WriteLine("");
double[,] Numbers = new double[Lines, Columns];
double[] NumbersSumm = new double[Columns];

for(int i = 0; i < Numbers.GetLength(0); i++){
        for(int j = 0; j < Numbers.GetLength(1); j++){
            Numbers[i,j]= new Random().Next(1,11);
            Console.Write($"{Numbers[i,j]}\t");
        }
        Console.WriteLine("");
}
Console.WriteLine("");
for(int i = 0; i < Columns; i++){
    NumbersSumm[i] = 0;
    Console.Write($"Столбик под номером {i + 1} имеет следующие числа: ");
    for(int j = 0; j < Lines; j++){
        for(int k = 0; k < Columns; k++){
            if(i == k){
                NumbersSumm[i]= NumbersSumm[i] + Numbers[j,k];
                Console.Write($" {Numbers[j,k]} ");
            }
        }
    }
    Console.WriteLine($"- среднее арифметическое данных чисел равна {Math.Round(NumbersSumm[i] / Lines,1)}");
}
