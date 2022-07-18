String Number = CheckInput();

for(int i = 0; i <= Number.Length/2; i++)
{
    if(Number[i] == Number[Number.Length-1-i])
    {
        Console.WriteLine("Данное число является полиндромом!\n");
        break;
        }
    else
    {
        Console.WriteLine("Данное число не является полиндромом!\n");
        break;
    }
}

string CheckInput()
{   
    string Text;
    int Repeat = 0;
    while(true)
    {   
        
        Console.Write("\nВведите пятизначное число: ");
        Text = Console.ReadLine();
        
        for(int i = 0; i < Text.Length; i++)
        {
            if(Text.Length != 5 ||
            Text[i] != '0' &&
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