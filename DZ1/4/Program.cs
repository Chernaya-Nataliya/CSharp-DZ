// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
{
    int a, b, c;
    Console.Write("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    c = Convert.ToInt32(Console.ReadLine());
if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine($"Наибольшее число: {a}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число: {c}");
        }
    }
    else if (b > c)
        Console.WriteLine($"Наибольшее число: {b}");
    else
        Console.WriteLine($"Наибольшее число: {c}");
}
