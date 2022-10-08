// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Num = ReadInt("Введите число: ");
int Num1 = Nums(Num);
SumNum(Num, Num1);
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int Nums(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNum(int b, int Num1)
{
    int sum = 0;
    for (int i = 1; i <= Num1; i++)
    {
        sum += b % 10;
        b /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
}