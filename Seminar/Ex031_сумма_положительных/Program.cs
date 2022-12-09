// массив рандом от-9 до 9-Ю сумму положительных и сумму отрицательных.
// Console.Clear();
int[] array = new int[12];

void Fill(int[] mass, int Min, int Max)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(Min, Max);
    }
}

void CountNP(int[] mass)
{
    int sumNegative = 0;
    int sumPositive = 0;

    foreach (int X in mass)
    {
        sumNegative += X < 0 ? X : 0;
        sumPositive += X > 0 ? X : 0;
    }


    // for (int j = 0; j < mass.Length; j++)
    //     if (mass[j] < 0)
    //     {
    //         sumNegative = sumNegative + mass[j];
    //     }
    //     else
    //     {
    //         sumPositive = sumPositive + mass[j];
    //     }
    Console.WriteLine($"Sum of Negative =  {sumNegative}");
    Console.WriteLine($"Sum of Positive =  {sumPositive}");
}

Fill(array, -9,9);
Console.WriteLine($"[{String.Join(",", array)}]");
CountNP(array);
