string MenuNumber;
char Question;
while(true)
{
    Console.Clear();
    Console.WriteLine("Первый вариант >> 1 << (Предврительно запрашивает количество чисел в массиве)");
    Console.WriteLine("Второй вариант >> 2 << (Колхоз,использование большого массива, чтобы не запрашивать количество чисел в массиве!)");
    Console.WriteLine("Третий вариант >> 3 << (Использование списков List, что позволяет ввести желаемое количество чисел)");
    Console.Write("Выбирите вариацию реализации даной задачи(От 1 до 3): ");
    MenuNumber = Console.ReadLine();
    
    switch(MenuNumber)
    {
        case "1":
            FirstOption();
            break;
        case "2":
            SecondOption();
            break;
        case "3":
            ThirdOption();
            break;
        default:
            Console.WriteLine("\n=>> Вы ввели некорректные данные! <<=");
            break;
    }
    Console.Write($"\nСделать повторный выбор варианта?(y/n)");
    Question = char.Parse(Console.ReadLine());
    if( Question != 'y'){
        break;
    }
}

//Вариант 1(Предврительно запрашивать количество чисел в массиве).
void FirstOption(){
    Console.Write("\nНахождетие количесва положительных чисел в массиве.");
    Console.Write("\nВведите количество чисел в массиве: ");
    int Enumerator= 0;
    int Quantity = int.Parse(Console.ReadLine());
    int[] Numbers = new int[Quantity];
    for(int i = 0; i < Numbers.Length; i++){
        Console.Write($"\nЧисло {i+1} равно ");
        Numbers[i] = int.Parse(Console.ReadLine());
        if(Numbers[i] > 0){
            Enumerator++;
        }
    }
Console.WriteLine($"\nКоличество чисел больших 0 в массиве равно {Enumerator}");
}

//Вариант 2.(Колхоз,использование большого массива, чтобы не запрашивать количество чисел в массиве!)
void SecondOption(){
    char Question;
    int[] Numbers = new int[50];
    int Enumerator= 0;
    int i = 0;
    Console.Write("\nНахождетие количесва положительных чисел в массиве.");
    while(i < Numbers.Length){
        Console.Write($"\nУ Вас есть лимит чисел {i+1} из 50 \nЧисло {i+1} равно ");
        Numbers[i] = int.Parse(Console.ReadLine());
        Console.Write($"\nВы хотите ввести ещё одно число?(y/n)");
        Question = char.Parse(Console.ReadLine());
        if(Numbers[i] > 0){
            Enumerator++;
        }
        if( Question != 'y'){
            break;
        }
        i++;    
    }
    Console.WriteLine($"\nКоличество чисел больших 0 в массиве равно {Enumerator}");
}

//Вариант 3. (Использование списков List, что позволяет ввести желаемое количество чисел)
void ThirdOption(){
    List<int> Numbers = new List<int> {};
    int index = 0;
    int Enumerator= 0;
    char Question;
    Console.Write("\nНахождетие количесва положительных чисел в массиве.");
    while(true){
        Console.Write($"\nЧисло {index+1} равно ");
        Numbers.Add(index);
        Numbers[index] = int.Parse(Console.ReadLine());
        if(Numbers[index] > 0){
            Enumerator++;
        }
        Console.Write($"\nВы хотите ввести ещё одно число?(y/n)");
        Question = char.Parse(Console.ReadLine());
        if( Question != 'y'){
            break;
        }
        index++;
    }
    Console.WriteLine($"\nКоличество чисел больших 0 в массиве равно {Enumerator}");
}