﻿while(true){
    int Columns;
    int Lines;
    Console.Clear();
    // Ошибся при запросе на ввод переменных для значений строк и столбцов. Ошибку исправил
    Console.Write("Заполнеие двумерного массива случайными вещественными числами. \n\nВведите размер массива. \nКоличество строк: ");
    Lines = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов: ");
    Columns = int.Parse(Console.ReadLine());
    Console.Write("\nРезультат генерации массива:\n");

    double [,] Numbers = new double[Lines,Columns];

    for(int i = 0; i < Numbers.GetLength(0); i++){
        for(int j = 0; j < Numbers.GetLength(1); j++){
            Numbers[i,j] = new Random().NextDouble() + new Random().Next(-10,11);
            Console.Write($"{Math.Round(Numbers[i,j], 1)}\t");
        }
        Console.WriteLine("");
    }
    
    Console.Write("\nХотите попробовать ещё раз?(y/n)");
    char a = char.Parse(Console.ReadLine());
    if(a != 'y'){
        break;
    }
}