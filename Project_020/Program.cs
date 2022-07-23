//Пользователь создаёт массив 
Console.Clear();
Console.Write("До начала программы Вам необходимо ввести размер массива\n\nКоличество строк в массиве: ");
int  Lines= int.Parse(Console.ReadLine());
Console.Write("Количетсов столбцов в массиве: ");
int Columns = int.Parse(Console.ReadLine());

int[,] Numbers = new int[Lines, Columns];
for(int i = 0; i < Numbers.GetLength(0); i++){
    for(int j = 0; j < Numbers.GetLength(1); j++){
        Numbers[i,j]= new Random().Next(-50,51);
    }
}
//Выводит меню для выбора определенного метода
while(true){
    Console.Clear();
    InputArray();

    Console.Write("1.Поиск числа по позиции в массиве\n");
    Console.Write("2.Поиск позиции числа в массиве\nЧто ищем?(1 или 2) или Вы хотите заврешить программу(q) : ");
    char Choice = char.Parse(Console.ReadLine());
    switch(Choice){
        case '1':
            PositionSearch();
            break;
        case '2':
            NumberSearch();
            break;
        case 'q':
            break;
        default:
            Console.Write("\n   =>>Вы ввели не верные данные!<<=");
            break;
    }
    if(Choice != 'q'){
        Console.Write("\nЖелаете вернуться к меню(y) или завершить работу программы(n)?(y/q)");
        char Question = char.Parse(Console.ReadLine());
        if(Question != 'y'){
            break;
        }
    }else{
        break;
    }
}
//Поиск числа по позиции в массиве
void PositionSearch(){
    while(true){
        Console.Clear();
        InputArray();
        int Key = -1;
        Console.Write("Чтобы найти число по позицие необходимо ввести столбец и строку числа\nКакая строка: ");
        int Line = int.Parse(Console.ReadLine());
        Console.Write("Какой столбик: ");
        int Column= int.Parse(Console.ReadLine());
        
        for(int i = 0; i < Numbers.GetLength(0); i++){
            for(int j = 0; j < Numbers.GetLength(1); j++){
                if(Line > Numbers.GetLength(0) && Column > Numbers.GetLength(1)){
                    Console.Write($"Такой позиции в массиве нет");
                    Key = i;
                    break;
                }
                if(Column - 1 == i && Line - 1 == j){
                    Console.WriteLine($"Позиция ({Line},{Column}) имеет число {Numbers[Line-1,Column-1]}");
                    Key = i;
                    break;
                }    
            }
            if(Key == i){
                break;
            }
        }
        
        Console.Write("\nХотите найти другое число?(y/n)");
        char a = char.Parse(Console.ReadLine());
        if(a != 'y'){
            break;
        }
    }
}
//Поиск позиции числа в массиве
void NumberSearch(){
    while(true){
        Console.Clear();
        InputArray();
        int Key = -1;
        Console.Write("Введите число из массива которое необходимо найти: ");
        int Number = int.Parse(Console.ReadLine());
        for(int i = 0; i < Numbers.GetLength(0); i++){
            for(int j = 0; j < Numbers.GetLength(1); j++){
                if(Key == -1 && i == Numbers.GetLength(0) - 1 && j == Numbers.GetLength(1) - 1 && Number != Numbers[i,j]){
                    Console.Write($"Число {Number} в массиве нет!");
                }
                if(Key == 1 && Number == Numbers[i,j]){
                    Console.Write($" и ({i + 1},{j + 1})");
                    break;
                }
                else if(Number == Numbers[i,j]){
                    Console.Write($"Число {Number} имеет позицию ({i + 1},{j + 1})");
                    Key = 1;
                    break;
                }    
            }
        }
        Console.Write("\nХотите найти позицию другого числа?(y/n)");
        char a = char.Parse(Console.ReadLine());
        if(a != 'y'){
            break;
        }   
    }
}
//Метот для вывода массива
void InputArray(){
    for(int i = 0; i < Numbers.GetLength(0); i++){
        for(int j = 0; j < Numbers.GetLength(1); j++){
            Console.Write($"{Numbers[i,j]}\t");
        }
        Console.WriteLine("");
    }
}
