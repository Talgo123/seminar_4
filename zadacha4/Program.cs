Console.Clear();

int[] RandomDigit(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i;
    for (i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}
int size = EntryNumber("введите число: ");
int[] massiv = new int[size];
RandomDigit(massiv);
PrintArray(massiv);
