// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int NumThree(int Num3)
{
    int result = new int();
    result = Num3 % 100;
    result /= 10;
    return result;
}
Console.WriteLine("Введите трехзначное число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());
if( Num3 > 99 & Num3 < 1000 )
{
    int Num2 = NumThree(Num3);
    Console.WriteLine(Num2);
}
else if( Num3 < -99 & Num3 > -1000 )
{
    int Num2 = NumThree(Num3);
    Num2 *= -1;
    Console.WriteLine(Num2);
}
else
{
    Console.WriteLine("Число не является трехзначным");
}