// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8];
// Console.WriteLine($"{x}");

Fill(array);
Print(array);

void Fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)

        arr[i] = new Random().Next(1, 100);
}

void Print(int[] coll)
{
    for(int j = 0; j < coll.Length; j++)
    Console.Write($"{coll[j]} ");
}

