// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Num = RealInt("Введите число N, которое больше 0: ");
for (int i = 1; i <= Num; i++)
{
    Console.WriteLine($"{i*i*i} ");
}
int RealInt(string result)
{
    Console.WriteLine(result);
    return Convert.ToInt32(Console.ReadLine());
}