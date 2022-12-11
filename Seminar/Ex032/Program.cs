// минус на плюс и наоборот

int[] array = Fill(20, -9, 19);

int[] Fill(int size, int min, int max)
{
    int[] mass = new int[size];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(min, max)+1;
    }

    return mass;
}

int[] PosNeg(int[] mass2)
{

    for (int i = 0; i < mass2.Length; i++)
    {
        mass2[i] *= -1;
    }

    return mass2;

}

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", PosNeg(array))}]");
