// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
void printArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(", "); 
        }
    }
    Console.WriteLine("]");
}

void FillArray(int[] arrayToFill, int diviation)
{
    for (int i = 0; i < arrayToFill.Length; i++)
        arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
}

void CopyArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}

int arraySize = 0;
arraySize = new Random().Next(5, 20);
int[] firstArray = new int[arraySize];
int[] secondArray = new int[arraySize];
FillArray(firstArray, 20);
CopyArray(firstArray, secondArray);
Console.Clear();

Console.WriteLine("Первый массив: ");
printArray(firstArray);
Console.WriteLine();
Console.WriteLine("Второй массив (копия)): ");
printArray(secondArray);