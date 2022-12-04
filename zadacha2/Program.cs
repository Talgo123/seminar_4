// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindAmountDigit(int number)
{
    int i = 0;
    for (i = 0; number > 0; i++)
    {
       number = number / 10; 
    }
    return i;
}
int number = EntryNumber("Введите число: ");
int result = FindAmountDigit(number);
Console.WriteLine($"колличество цифр в числе {number} равно {result}");