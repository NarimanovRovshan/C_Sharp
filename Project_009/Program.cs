Console.WriteLine("\nНахождение расстояния между двумя точками в 3D пространстве");

Console.WriteLine("\nВведите координаты точки A:");
double[] CoordinatesA;
CoordinatesA = InputCoordinates();
Console.WriteLine("\nВведите координаты точки B:");
double[] CoordinatesB;
CoordinatesB = InputCoordinates();

double[] InputCoordinates()
{   
    char[] XYZ = {'X', 'Y', 'Z'}; 
    double[] Coordinates = new double[3];
    for(int i = 0; i < Coordinates.Length; i++)
    {
        Console.Write($"Координата {XYZ[i]}: ");
        Coordinates[i] = double.Parse(Console.ReadLine());
    }
    return Coordinates; 
}

double result = Math.Round(Math.Sqrt(Math.Pow(CoordinatesB[0]-CoordinatesA[0],2) + Math.Pow(CoordinatesB[1]-CoordinatesA[1],2) + Math.Pow(CoordinatesB[2]-CoordinatesA[2],2)),2);

Console.WriteLine($"\nРасстояние между точками A и B в 3D пространстве равна {result}\n");