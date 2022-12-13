// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите через пробел позицию элемента: ");
string[] tokens = Console.ReadLine().Split(' ');
int rows = int.Parse(tokens[0]);
int colums = int.Parse(tokens[1]);

int[,] matrix = new int[5, 5];

void FillMatrix(int[,] matr, int minValue, int maxValue)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

}

FillMatrix(matrix, 1, 9);

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintMatrix(matrix);

bool FindElement(int[,] mass, int rowsFind, int columsFind)
{
    return (rowsFind<mass.GetLength(0) && columsFind<mass.GetLength(1));
}

if (FindElement(matrix, rows, colums))
{
    Console.WriteLine($"Значение искомого элемента: {matrix[rows, colums]}");
}
else
{
    Console.WriteLine($"Позиция не существует в данном массиве");
}