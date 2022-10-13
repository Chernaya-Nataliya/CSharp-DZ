//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите минимальный диапазон значений в массиве: ");
int DMin =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон значений в массиве: ");
int DMax =Convert.ToInt32(Console.ReadLine());
Console.Write("[");
double[] arrayNumbers = new double[5];
  for (int i = 0; i < arrayNumbers.Length; i++ )
     {
    arrayNumbers[i] = new Random().Next(DMin, DMax +1);
    
    Console.Write(arrayNumbers[i] + " ");
    }
   
double max = arrayNumbers[0];
double min = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (max < arrayNumbers[i])
    {
      max = arrayNumbers[i];
    }
        if (min > arrayNumbers[i])
    {
      min = arrayNumbers[i];
    }
  }
Console.WriteLine("]");
  double decision = max - min;

  Console.WriteLine($"Разница между максимальным ({max}) и минимальным({min}) элементами: {decision}");