// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Num = ReadInt("Введите цифру, обозначающую день недели: ");
Console.WriteLine(Day(Num));
int ReadInt(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine()); 
}
string Day(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Выходной");
        }
        else
       {
            Console.Write("Рабочий");
        }
    }
    else
    {
        Console.Write("ОШИБКА! Нужно ввести число в пределах от 1 до 7, невозможно определить");
    }
    return " день.";
}