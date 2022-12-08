// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine());
int length = num.ToString().Length;
int[] array = new int[length];

for (int i = length - 1; i >=0; i = i -1)
{
    array[i] = num % 10;
    num = num / 10;
}



void PrintArray(int[] arr)
{
    for(int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]}");
    }
}

PrintArray(array);