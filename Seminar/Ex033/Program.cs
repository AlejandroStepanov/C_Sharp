// Задать массив. Присутствует ли искомое Х в массиве?

int[] array = Fill(10, 1, 10);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Введите искомое число: ");
int X = int.Parse(Console.ReadLine());
YesOrNo(array, X);


int[] Fill(int size, int min, int max)
{
    int[] mass = new int[size];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(min, max) + 1;
    }

    return mass;
}



bool YesOrNo(int[] mass, int i)
{
    foreach (int j in mass)
    {
        if (j == i)
            return true;
    }
    return false;
}

//Кирилл
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)
{
    foreach (var item in array)
    {
        if (el == item) return true;
    }
    return false;
}