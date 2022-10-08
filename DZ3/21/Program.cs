// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Coordinate (string Dan)
{
    int result = 0;
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine($"OШИБКА! Введите целое число. {Dan}: ");
    }
    return result;
}
Console.WriteLine("Введите координаты первой точки: ");
int DanX1 = Coordinate("X1 = ");
int DanY1 = Coordinate("Y1 = ");
int DanZ1 = Coordinate("Z1 = ");
Console.WriteLine("Введите координаты второй точки: ");
int DanX2 = Coordinate("X2 = ");
int DanY2 = Coordinate("Y2 = ");
int DanZ2 = Coordinate("Z2 = ");
double SBetweenTwoPoints(int cdX1, int cdY1, int cdZ1, int cdX2, int cdY2, int cdZ2)
{
   return Math.Sqrt(Math.Pow(cdX2 - cdX1, 2) + Math.Pow(cdY2 - cdY1, 2) + Math.Pow(cdZ2 - cdZ1, 2)); 
}
Console.WriteLine($"Длина отрезка: " + SBetweenTwoPoints(DanX1, DanY1, DanZ1, DanX2, DanY2, DanZ2));