// массив из 123. Лежит ли в отрезке от 10 до 99?

int[] array = Fill(123, 9, 99);

int[] Fill(int size, int min, int max)
{
    int[] mass = new int[size];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(min, max + 1);
    }

    return mass;
}

Console.WriteLine($"[{String.Join(",", array)}]");

void Count(int[] mass)
{
    int count = 0;
    foreach (int x in mass)
    {
        if (x >= 9 && x <= 100)
            count++;
    }
    Console.WriteLine(count);
}

Count(array);