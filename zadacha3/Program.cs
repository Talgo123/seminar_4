Console.Clear();

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int NumberProduction(int number)
{
    int i;
    int prod = 1;
    for (i = 1; i <= number; i++)
    {
        prod = prod * i; 
    }
    return prod;
}

int number = EntryNumber("Введите число: ");
int result = NumberProduction(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");