// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
string? Num = Console.ReadLine();
int Ln = Num.Length;
if (Ln == 5)
{
    if (Num[0] == Num[4] && Num[1] == Num[3])
    {
        Console.WriteLine($"Число {Num} - является палиндромом");
    }
    else
    {
        Console.WriteLine ($"Число {Num} - не является палиндромом");
    }    
}
else
{
    Console.WriteLine($"ОШИБКА: Число {Num} - не является пятизначным числом");
}