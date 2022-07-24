Console.Clear();
Console.WriteLine("Программа меняющая меставми выбранные строки в массиве");
Console.Write("\nДо начала программы Вам необходимо ввести размер массива\n\nКоличество строк в массиве: ");
int Lines = int.Parse(Console.ReadLine());
Console.Write("Количетсов столбцов в массиве: ");
int Columns = int.Parse(Console.ReadLine());

int[,] Numbers = new int[Lines,Columns];
int[] FirstLines = new int[Columns];
int[] SecondLines = new int[Columns];
Console.WriteLine("");
for(int i = 0; i < Lines; i++){
    Console.Write($"{i + 1}:\t");
    for(int j = 0; j < Columns; j++){
        
        Numbers[i,j] = new Random().Next(0,11);
        Console.Write($"{Numbers[i,j]}\t");
    }
    Console.WriteLine("");
}

Console.Write("\nВыберите строчки котороые Вы хотите поменять местами\n\nНомер первой строки: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Номер второй строки: ");
int B = int.Parse(Console.ReadLine());
int Replacement;
if(A > B){
    Replacement = A;
    A = B;
    B = Replacement;
}

Console.WriteLine("");
for(int i = 0; i < Lines; i++){
    for(int j = 0; j < Columns; j++){
        
        if(i == A - 1){
            FirstLines[j] = Numbers[i,j];
        }
        if(i == B - 1){
            SecondLines[j] = Numbers[i,j];
            Numbers[i,j] = FirstLines[j];
        }
    }
}

for(int i = 0; i < Lines; i++){
    Console.Write($"{i + 1}:\t");
    for(int j = 0; j < Columns; j++){
        if(i == A - 1){
            Numbers[i,j] = SecondLines[j];
        }
        Console.Write($"{Numbers[i,j]}\t");
    }
    Console.WriteLine("");
}
Console.WriteLine("");