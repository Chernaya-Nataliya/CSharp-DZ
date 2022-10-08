// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int Num = 8;
Console.WriteLine("Введите минимальный диапазон значений в массиве: ");
int Min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон значений в массиве: ");
int Max =Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Num];
for (int i = 0; i < Num; i++)
{
    Array[i] = new Random().Next(Min, Max +1);
}
void printArray(int[] array) 
{
        Console.WriteLine($"Массив размером {Num} с диапазоном значений от {Min} до {Max} включительно:");
        Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(","); 
        }
    }
    Console.WriteLine("]");
}
printArray(Array);