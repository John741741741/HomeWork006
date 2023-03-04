// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите числа через пробел");
int[] numbers = Console.ReadLine().Split(" "). Select(e => Convert.ToInt32(e)).ToArray();
int count=0;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    count++; 
}
System.Console.Write($" -> {count} чисел/ла больше 0 ввёл пользователь");
