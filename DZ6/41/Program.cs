// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine($"Введите число М(какое количество чисел вы желаете видеть): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Num = new int[m];

void InputNum(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    Num[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Compr(int[] Num)
{
  int count = 0;
  for (int i = 0; i < Num.Length; i++)
  {
    if(Num[i] > 0 ) count += 1; 
  }
  return count;
}

InputNum(m);

Console.WriteLine($"Введено чисел больше нуля: {Compr(Num)} ");