// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] RandomArrey(int Num)
{
    int[] Array = new int [Num];
    var RD = new Random();
    Console.WriteLine($"Полученный рандомный массив положительных трехзначных чисел длиной {Num}");
    for(int i = 0; i < Num; i++)
    {
        Array[i] = RD.Next(100, 1000);
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine("");
    return Array;
}

int PositivNum(int[] Arrey)
{
    int count = 0;
    for (int i = 0; i < Arrey.Length; i++)
    {
        if(Arrey[i] % 2 == 0)
        {
            count++;
        }        
    }    
    return count;
}

Console.WriteLine("Введите желаемую длину массива : ");
int Num = Convert.ToInt32(Console.ReadLine());
int[] RA = RandomArrey(Num);
int Positiv = PositivNum(RA);
Console.WriteLine($"Этот массив состоит из {Positiv} четных чисел");
