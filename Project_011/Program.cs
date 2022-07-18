
Console.WriteLine("\nВозведение числа в натуральную степень.");
Console.Write("\nВведите число: ");
double Number = double.Parse(CheckInput());
Console.Write("\nВведите степень: ");
int Degree = int.Parse(CheckInput());
double Result = Number;

//Решение без цикла
//Console.WriteLine($"\nРезультат: {Math.Pow(Number,Degree)}\n"); 

for(int i = 1; i < Degree; i++)
{
    Result = Result * Number;
}

Console.WriteLine($"\nРезультат {Result}\n"); 

string CheckInput()
{   
    string Text;
    int Repeat = 0;
    while(true)
    {   
        
        Text = Console.ReadLine();
        
        for(int i = 0; i < Text.Length; i++)
        {
            if(Text[i] != '0' &&
            Text[i] != '1' &&
            Text[i] != '2' &&
            Text[i] != '3' &&
            Text[i] != '4' &&
            Text[i] != '5' &&
            Text[i] != '6' &&
            Text[i] != '7' &&
            Text[i] != '8' &&
            Text[i] != '9')
            {
                Console.WriteLine("=>> Вы ввели неверные данные! <<=");
                Repeat = 0;
                break;
            }
            else
            {
                Repeat = 1;
            }
        }

        if(Repeat == 1){
            return(Text);
        }
    }
}