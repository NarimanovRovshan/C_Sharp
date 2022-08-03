Console.Clear();
Console.WriteLine("Нахождение точки пересечения двух прямых, заданных уравнениями");
Console.WriteLine("\nВведите значени k и b к двум уровнениям типа y = k * x + b");

double x, y, b, k;
Console.Write("\nЗначение k первого уровнения: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Значение b первого уровнения: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("\nЗначение k второго уровнения: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Значение b второго уровнения: ");
double b2 = double.Parse(Console.ReadLine());

if(b1 < 0){
    Console.WriteLine($"\nМы получили два уровнения\n   y = {k1} * x - {b1 * (-1)}");    
    if(b2 < 0){
        Console.WriteLine($"   y = {k2} * x - {b2 * (-1)}");
    }
    else{
        Console.WriteLine($"   y = {k2} * x + {b2}");
    }
}
else if(b1 >= 0){
    Console.WriteLine($"\nМы получили два уровнения\n   y = {k1} * x + {b1}");
    if(b2 < 0){
        Console.WriteLine($"   y = {k2} * x - {b2 * (-1)}");
    }
    else{
        Console.WriteLine($"   y = {k2} * x + {b2}");
    }
}
if(k1 != k2){
    b = b1 + b2 * (-1);
    k = k1 + k2 * (-1);
    x = b / (k * (-1));
    y = k2 * x + b2;
    Console.WriteLine($"\nТочка пересечения двух прямых, заданных данными уравнениями равна ({x}:{y})\n");
} else{
    Console.WriteLine($"\nЕсли k1 = k2 то прямые являются параллельными и в таком случае у них нет точек пересечения\n");
}