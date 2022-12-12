// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите 'b1' , 'k1' , 'b2' , 'k2' через пробел: ");
string text = Console.ReadLine();
int[] array = ArrFromString(text);

int[] ArrFromString (string text)
{
    string[] nums = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}


Console.WriteLine($"[{String.Join(",", array)}]");