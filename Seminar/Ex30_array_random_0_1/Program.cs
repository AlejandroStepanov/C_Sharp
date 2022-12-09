// Создает массив из 8 эл и заполняет рандомно 0 и 1.

Console.Clear();
int[] array = new int[8];

void FillArr(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

FillArr(array);

void print(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]}");
    }

}
FillArr(array);
print(array);

//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//Варриант Кирилла
int[] array = GetBinaryArray(20);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetBinaryArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}