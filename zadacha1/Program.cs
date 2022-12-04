Console.Clear();

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// пишем цикл от 1 до А
// суммируем итератор

int FindNumber(int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ = summ + i;
    }
    return summ;
}

int number = EntryNumber("Введите число:");
int result = FindNumber(number);
Console.WriteLine($"{number} -> {result} ");
