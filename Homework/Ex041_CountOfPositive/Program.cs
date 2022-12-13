// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите числа через через пробел: ");
string text = Console.ReadLine();

int[] ArrFromString(string text)
{
    string[] nums = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int[] array = ArrFromString(text);

Console.WriteLine($"[{String.Join(", ", array)}]");

int CountPositive(int[] mass)
{
    int count = 0;
    foreach (int x in mass)
        if (x > 0) count++;
    return count;
}

Console.WriteLine($"Количество чисел больше нуля = {CountPositive(array)}");