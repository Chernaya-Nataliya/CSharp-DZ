// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];
ArrayDouble(array);
GetArray(array);

void ArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void GetArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      Console.Write("[ ");
      for (int j = 0; j < n; j++)
      {
        double Num = Math.Round(array[i, j], 1);
        Console.Write(Num + " ");
      }
      Console.Write("]");
      Console.WriteLine();
  }
}