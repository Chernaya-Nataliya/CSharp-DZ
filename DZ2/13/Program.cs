// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Numthree(int Num)
{
    int result = new int();
    while(Num > 1000 | Num < -1000 )
    {
        Num /= 10;
    }
    result = Num % 10;
    if(result < 0)
    {
        result *= -1;
    }    
    return result;
}
Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
if(Num < 100 && Num > -100)
Console.WriteLine("Третьей цифры нет");
else
{
    int num = Numthree(Num);
    Console.WriteLine(num);    
}