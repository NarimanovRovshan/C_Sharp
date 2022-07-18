// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nВвывод суммы цифр в числе.");
Console.Write("\nВведите число: ");
string Number = CheckInput();
int Summ = 0;
for(int i = 0; i < Number.Length; i++)
{
    int j = Number[i] - 48;
    Summ = Summ + j;
}

Console.WriteLine($"\nСумма цифр числа {Number} равна {Summ}.\n");

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
