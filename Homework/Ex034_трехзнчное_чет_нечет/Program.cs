// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = MakeArrRandon(20);
Console.WriteLine($"Сгенерированный массив: [{String.Join(",", array)}]");
Count(array);

int[] MakeArrRandon(int size)
{
    int[] random = new int[size];
    for (int i = 0; i < random.Length; i++)
    {
        random[i] = new Random().Next(99, 1000);
    }
    return random;
}

void Count(int[] arr)
{
    int count = 0;
    foreach (int x in arr)

        if (x%2 == 0 )
        count ++;

Console.WriteLine($"Количество чётных чисел в массиве = {count}");
}