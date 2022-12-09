// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] array = MakeArrayDouble(8);
Console.WriteLine($"Сгенерированный массив: [{String.Join(" , ", array)}]");
MinMax(array);

double[] MakeArrayDouble(int length) //, int Min, int Max)
{
    double[] random = new double[length];

    for (int i = 0; i < random.Length; i++)
    {
        random[i] = new Random().NextDouble() * 2 + 3;
    }
    return random;
}

void MinMax (double[] mass)
{
    double minValue = mass[0];
    double maxValue = mass[0];

    foreach (double X in mass)
    {
        if (X < minValue)
        {
            minValue = X;
        }
        if (X > maxValue)
        {
            maxValue = X;
        }
    }
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {maxValue-minValue}");
}