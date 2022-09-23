// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int startA = 1;
while (startA <= a)
{
    if (startA % 2 == 0)
    Console.WriteLine("Ответ: " + startA);
    startA ++;
}
if (a < 1)
{
    Console.WriteLine("Число не является четным");
}