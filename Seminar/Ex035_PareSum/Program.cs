// сумма пар чисел
Console.Clear();

int[] newArray = GetArray(3, 1, 15);
Console.WriteLine($"[{String.Join( ",", newArray)}]");

int[] GetArray(int size, int minRandom, int maxRandom)
{
    int[] result = new int[size];
    for(int i = 0; i<result.Length; i++)
    {
        result[i] = new Random().Next(minRandom, maxRandom+1);
    }
    return result;

}

void PareSum(int[] mass)
{
    int Sum = 0;
    int j = mass.Length -1;
    for(int i = 0; i< (mass.Length +1) /2; i++)
    {
        Sum = mass[i] + mass [j];
        Console.WriteLine(Sum);
        j--;
    }
    
}
PareSum(newArray);