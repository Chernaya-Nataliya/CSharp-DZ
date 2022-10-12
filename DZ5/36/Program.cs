// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите длину массива: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальнное знначение элементов массива: ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальнное знначение элементов массива: ");
int Max = Convert.ToInt32(Console.ReadLine());
int[] RandomArrey(int Num1, int Min1 , int Max1)
{
    int[] ResultArray = new int [Num1];
    var rnd = new Random();
    Console.WriteLine($"Полученный рандомный массив чисел диапазона от {Min1} до {Max1} длинной {Num1}");
    for(int i = 0; i < Num1; i++)
    {
        ResultArray[i] = rnd.Next(Min1, Max1 + 1);
        Console.Write($"{ResultArray[i]} ");
    }
    Console.WriteLine("");
    return ResultArray;
}

int SumOddPositionElements(int[] Arrey)
{
    int Sum = 0;
    for (int i = 1; i < Arrey.Length; i+= 2)
    {
        Sum += Arrey[i];
    }
    return Sum;
}
int[] Arrey = RandomArrey(Num, Min, Max );
int Sum = SumOddPositionElements(Arrey);
Console.WriteLine($"Сумма нечетных элементов рандомного массива длиной {Num} элемента равна {Sum}");