// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число, которое хотите возвести в степень: ");
double NumA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите степень, в которую хотите возвести число {NumA}: ");
double NumB = Convert.ToDouble(Console.ReadLine());
double ans = 1;
for (int i = 1; i <= NumB; i++)
{
    ans = ans * NumA;
}
Console.WriteLine($"Число {NumA} возведенное в степень {NumB} равно {ans}");