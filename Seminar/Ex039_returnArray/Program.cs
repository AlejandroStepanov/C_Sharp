//

Console.Clear();



int[] GetArray(int size, int minRandom, int maxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minRandom, maxRandom + 1);
    }
    return result;

}

int[] ReversArray(int[] collection)
{
    int[] result = new int[collection.Length];
    for (int i = 0; i < collection.Length; i++)
    {
        result [i] = collection[collection.Length - 1 -i];
    }


    // Console.WriteLine($"[{String.Join(",", result)}]");
    return result;
}

int[] newArray = GetArray(5, 1, 15);
Console.WriteLine($"[{String.Join(",", newArray)}]");
int[] reverseArray = ReversArray(newArray);
Console.WriteLine($"[{String.Join(",", reverseArray)}]");